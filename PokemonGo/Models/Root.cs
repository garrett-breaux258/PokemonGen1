using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokemonGo.Models
{
    public class Root
    {
        public Root()
        {
        }
        
        
      public List<Pokemon> pokemonList { get; set; }
        
    }

    
}
