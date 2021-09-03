using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonGo.Models
{
    public class Pokemon
    {
        public Pokemon()
        {
        }
        public int id { get; set; }
        public string num { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string[] type { get; set; }
        public string[] weaknesses { get; set; }
    }


}
