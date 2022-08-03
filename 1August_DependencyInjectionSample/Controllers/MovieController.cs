using _1August_DependencyInjectionSample.Models;
using _1August_DependencyInjectionSample.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1August_DependencyInjectionSample.Controllers
{
    public class MovieController : Controller
    {

        private readonly IMovieRepository _movieRepository;

        public List<Movie> Movies { get; set; } = new List<Movie>();   
        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        // GET: MovieController
        public async Task<IActionResult> Index()
        {
            var Movies =  _movieRepository.GetAll();
            return View(Movies);
        }

        //// GET: MovieController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: MovieController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: MovieController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MovieController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MovieController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MovieController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MovieController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
