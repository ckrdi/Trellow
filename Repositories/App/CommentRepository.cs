using Trellow.Data;
using Trellow.Interfaces.App;
using Trellow.Models.App;
using Trellow.Repositories.Base;

namespace Trellow.Repositories.App
{
    public class CommentRepository(AppDbContext context) : Repository<AppDbContext, Comment>(context), ICommentRepository
    {
    }
}
