using System;
using System.Collections.Generic;

namespace PokemonGo.Models
{
    public interface IPokemon
    {
        public IEnumerable<Pokemon> GetAllPokemon();
        public Pokemon GetPokemon(string name);

    }
    

}
