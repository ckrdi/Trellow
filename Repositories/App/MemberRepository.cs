using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class MemberRepository : Repository<AppDbContext, Member>
    {
        public MemberRepository(AppDbContext context) : base(context)
        {
        }
    }
}
