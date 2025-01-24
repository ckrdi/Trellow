using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class CardRepository : Repository<AppDbContext, Card>
    {
        public CardRepository(AppDbContext context) : base(context)
        {
        }
    }
}
