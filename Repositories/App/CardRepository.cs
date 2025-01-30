using Trellow.Data;
using Trellow.Interfaces.App;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class CardRepository(AppDbContext context) : Repository<AppDbContext, Card>(context), ICardRepository
    {
    }
}
