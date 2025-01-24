using Trellow.Data;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class CommentRepository : Repository<AppDbContext, Comment>
    {
        public CommentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
