using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Notes.Applications.Interfaces;

namespace Notes.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistense(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<NotesDbContext>(options =>
            {
                options.UseSqlite(connectionString); 
            });
            services.AddScoped<INotesDbContext>(provider =>
                (INotesDbContext)provider.GetServices<NotesDbContext>());
            return services; 
        }
    }
}
