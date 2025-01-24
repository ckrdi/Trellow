using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class ListRepository : Repository<AppDbContext, List>
    {
        public ListRepository(AppDbContext context) : base(context)
        {
        }
    }
}
