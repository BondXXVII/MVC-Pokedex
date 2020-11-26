using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokedexV.Models;
using PokedexV.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace PokedexV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PokedexVContext pokeBox;

        public HomeController(ILogger<HomeController> logger, PokedexVContext boxes)
        {
            _logger = logger;
            pokeBox = boxes;
        }

        // public IActionResult Index()
        // {
        //     return View(pokeBox.Pokemon.ToList());
        // }

        public async Task<IActionResult> Index(string searchString)
        {
            var pkmns = from m in pokeBox.Pokemon select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pkmns = pkmns.Where(s => s.Name.Contains(searchString));
            }

            return View(await pkmns.ToListAsync());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Jams()
        {
            return View();
        }
        public IActionResult Map()
        {
            return View();
        }
    }
}
