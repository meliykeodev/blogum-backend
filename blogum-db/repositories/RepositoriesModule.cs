using System;
using blogum_db.repository;
using Microsoft.Extensions.DependencyInjection;

namespace blogum_db.repositories
{
    public class RepositoriesModule
    {

        public RepositoriesModule(
            IServiceCollection services
            )
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
        }
    }
}
