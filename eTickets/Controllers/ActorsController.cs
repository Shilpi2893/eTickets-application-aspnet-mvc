using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ActorsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var actorsData = _appDbContext.Actors.ToList();
            return View(actorsData);
        }

        //Get: Actors/Create
        // async Task<IActionResult> we are removing async n Task because we are not performing any data
        // manipulaion
        public IActionResult Create()
        {
            return View();
        }
    }
}
