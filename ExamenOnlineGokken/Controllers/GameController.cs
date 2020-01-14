using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenOnlineGokken.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExamenOnlineGokken.Controllers
{
    public class GameController : Controller
    {
        protected GambleDbContext _gambleDbContext;
        public GameController(GambleDbContext gambleDbContext)
        {
            _gambleDbContext = gambleDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Home/Search")]
        public IActionResult AddGame()
        {
            
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("Home/Search")]
        //public async Task<IActionResult> AddGame()
        //{
        //    //check the model
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    //create actor
        //    var newGame = new 
        //    {
                
        //    };
            
        //}
    }
}