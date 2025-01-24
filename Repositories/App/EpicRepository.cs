using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class EpicRepository : Repository<AppDbContext, Epic>
    {
        public EpicRepository(AppDbContext context) : base(context)
        {
        }
    }
}
