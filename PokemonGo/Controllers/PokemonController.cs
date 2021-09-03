using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonGo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonGo.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonRepo _repo;
        public PokemonController()
        {
            _repo = new PokemonRepo();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var pokemonList = _repo.GetAllPokemon();
            return View(pokemonList);
        }
    }
}
