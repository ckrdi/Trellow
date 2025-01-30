using Trellow.Data;
using Trellow.Interfaces.App;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class ListRepository(AppDbContext context) : Repository<AppDbContext, List>(context), IListRepository
    {
    }
}
