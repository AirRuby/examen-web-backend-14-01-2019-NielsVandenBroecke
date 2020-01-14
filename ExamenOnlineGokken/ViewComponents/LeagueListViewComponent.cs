using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenOnlineGokken.ViewModels;
using ExamenOnlineGokken.Data;

namespace ExamenOnlineGokken.ViewComponents
{
    [ViewComponent(Name = "LeagueListViewComponent")]
    public class LeagueListViewComponent : ViewComponent
    {
        //private LeagueListViewComponent Leagues = new LeagueListViewComponent();

        protected GambleDbContext _gambleDbContext;
        public LeagueListViewComponent(GambleDbContext gambleDbContext)
        {
            _gambleDbContext = gambleDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var leagues = _gambleDbContext.League.ToList().OrderBy(l => l.Name);
            LeagueListViewComponentVM leagueListViewComponentVM = new LeagueListViewComponentVM();
            leagueListViewComponentVM.Leagues = leagues.ToList();

            return View(leagueListViewComponentVM);
        }
    }
}
