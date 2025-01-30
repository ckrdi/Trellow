using Trellow.Interfaces.App;
using Trellow.Repositories.App;

namespace Trellow
{
    public class Bootstrapper
    {
        public static void SetupRepositories(IServiceCollection services)
        {
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IEpicRepository, EpicRepository>();
            services.AddScoped<IListRepository, ListRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<ISprintRepository, SprintRepository>();
        }
    }
}