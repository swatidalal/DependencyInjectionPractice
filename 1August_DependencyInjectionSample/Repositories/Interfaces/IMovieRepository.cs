using _1August_DependencyInjectionSample.Models;

namespace _1August_DependencyInjectionSample.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie GetByID(int id);
    }
}
