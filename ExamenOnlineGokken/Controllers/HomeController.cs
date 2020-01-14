﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamenOnlineGokken.Models;
using ExamenOnlineGokken.Data;
using ExamenOnlineGokken.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ExamenOnlineGokken.Controllers
{
    public class HomeController : Controller
    {
        protected GambleDbContext _gambleDbContext;
        public HomeController(GambleDbContext gambleDbContext)
        {
            _gambleDbContext = gambleDbContext;
        }
        public async Task<IActionResult> Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Title = "Upcoming games";
            homeIndexVM.Games = await _gambleDbContext.Games
                .Include(g => g.Bets)
                .ThenInclude(b => b.User).OrderBy(g => g.DateOfGame)
                .ToListAsync();
            return View(homeIndexVM);
        }

       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/ByLeague")]
        [Route("Home/FindByLeague/{LeagueId}")]
        public IActionResult FindByLeague(int LeagueId)
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM();

            if (LeagueId == null)
            {
                homeIndexVM.Title = "Selecteer een League";
            }
            else
            {
                homeIndexVM.Title = "Games uit geselecteerde league";

                homeIndexVM.Games = _gambleDbContext.Games.Where(g => g.LeagueId == LeagueId)
                    .Include(g => g.Bets)
                    .ThenInclude(b => b.User).OrderBy(g => g.DateOfGame)
                    .ToList();
            }

            return View(homeIndexVM);
        }
    }
}
