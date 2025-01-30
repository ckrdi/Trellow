using Trellow.Data;
using Trellow.Interfaces.App;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class EpicRepository(AppDbContext context) : Repository<AppDbContext, Epic>(context), IEpicRepository
    {
    }
}
