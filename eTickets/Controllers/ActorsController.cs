using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var actorsData = await _actorsService.GetAllActors();
            return View(actorsData);
        }

        // This is simple "Get" request: Actors/Create
        // async Task<IActionResult> we are removing async n Task because we are not performing any data
        // manipulaion
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor) 
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            _actorsService.Add(actor);
            return RedirectToAction("Index");
        }
    }
}
