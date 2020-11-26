using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexV.Data;
using PokedexV.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace PokedexV.Controllers
{
    public class DexController : Controller
    {
        // GET: /Dex/ was /HellowWorld

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // GET: /Dex/Welcome was /HelloWorld/Welcome/ 

        private readonly ILogger<DexController> _logger;
        private PokedexVContext pokeBox;

        public DexController(ILogger<DexController> logger, PokedexVContext boxes)
        {
            _logger = logger;
            pokeBox = boxes;
        }



        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult Show()
        {
            return View();
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var pkmns = from m in pokeBox.Pokemon select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pkmns = pkmns.Where(s => s.Name.Contains(searchString));
            }

            return View(await pkmns.ToListAsync());
        }
    }
}