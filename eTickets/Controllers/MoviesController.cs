﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public MoviesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }

        public async Task<IActionResult> Index()
        {
            var moviesData = await _appDbContext.Movies.Include(c => c.Cinema).OrderBy(x => x.Name).ToListAsync();
            return View(moviesData);
        }
    }
}
