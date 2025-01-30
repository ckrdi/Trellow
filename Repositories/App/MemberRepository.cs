using Trellow.Data;
using Trellow.Interfaces.App;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class MemberRepository(AppDbContext context) : Repository<AppDbContext, Member>(context), IMemberRepository
    {
    }
}
