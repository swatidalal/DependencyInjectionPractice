using _1August_DependencyInjectionSample.Repositories;
using _1August_DependencyInjectionSample.Repositories.Interfaces;

namespace _1August_DependencyInjectionSample.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices( this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>(); 

        }
    }
}
