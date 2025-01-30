using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trellow.Controllers.Requests.Epic;
using Trellow.Interfaces.App;
using Trellow.Models.App;

namespace Trellow.Controllers
{
    [ApiController]
    [Route("epics")]
    public class EpicsController : ControllerBase
    {
        private readonly IEpicRepository _epicRepository;

        public EpicsController(
            IEpicRepository epicRepository
            )
        {
            _epicRepository = epicRepository;
        }

        // GET: epics
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var epics = await _epicRepository.ReadAllAsync();
            var list = epics.Where(item => item.DeletedAt == null).ToList();

            return Ok(list);
        }

        // GET: epics/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epic = await _epicRepository.ReadAsync(id.Value);
            if (epic == null)
            {
                return NotFound();
            }

            return Ok(epic);
        }

        // POST: epics
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            var epic = new Epic
            {
                Code = request.Code,
                Title = request.Title,
                Description = request.Description,
                Color = request.Color,
                Status = request.Status,
                IssueType = request.IssueType,
                ReporterId = request.ReporterId,
                AssigneeId = request.AssigneeId,
                IsDummy = request.IsDummy,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var created = await _epicRepository.InsertAsync(epic);
            return Created(string.Empty, created);
        }

        // POST: epics/edit/5
        [HttpPost("edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Epic epic)
        {
            if (id != epic.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            try
            {
                epic.UpdatedAt = DateTime.UtcNow;
                var updated = await _epicRepository.UpdateAsync(epic);
                if (updated == null)
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!await EpicExistsAsync(epic.Id))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(500, e.InnerException);
                }
            }

            var read = await _epicRepository.ReadAsync(epic.Id);
            return Ok(read);
        }

        // POST: epics/delete/5
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var epic = await _epicRepository.ReadAsync(id);
            if (epic == null)
            {
                return NotFound();
            }

            try
            {
                epic.DeletedAt = DateTime.UtcNow;
                var updated = await _epicRepository.UpdateAsync(epic);
                if (updated == null)
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!await EpicExistsAsync(epic.Id))
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(500, e.InnerException);
                }
            }

            var read = await _epicRepository.ReadAsync(epic.Id);
            return Ok(read);
        }

        private async Task<bool> EpicExistsAsync(int id)
        {
            return await _epicRepository.IsDataExistsAsync(id);
        }
    }
}
