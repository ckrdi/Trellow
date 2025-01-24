using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class SprintRepository : Repository<AppDbContext, Sprint>
    {
        public SprintRepository(AppDbContext context) : base(context)
        {
        }
    }
}
