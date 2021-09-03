using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace PokemonGo.Models
{
    public class PokemonRepo : IPokemon 
    {
        

        public PokemonRepo()
        {      
        }

        public IEnumerable<Pokemon> GetAllPokemon()
        {
            var info = new Pokemon();
            var pokeFile = File.ReadAllText("../PokemonGo/pokedex.json");

            var parsedPokeFile = JObject.Parse(pokeFile).GetValue("pokemon");
            List<Pokemon> pokemonList = new List<Pokemon>();
            foreach (var item in parsedPokeFile)
            {
                info = System.Text.Json.JsonSerializer.Deserialize<Pokemon>(item.ToString());
                //Console.WriteLine(info.id);
                //Console.WriteLine(info.num);
                //Console.WriteLine(info.name);          
                //Console.WriteLine(info.img);
                //Console.WriteLine();

                //Console.WriteLine("[   ");

                //foreach (var type in info.type)
                //{
                //    Console.WriteLine(type);
                //}

                //Console.WriteLine("]   ");
                //Console.WriteLine();

                //Console.WriteLine("[");
                //    foreach (var weaknesses in info.weaknesses)
                //    {
                //    Console.WriteLine(weaknesses);
                //    }
                //Console.WriteLine("]");


                pokemonList.Add(info);
               
            }
            return pokemonList;
        }

        public Pokemon GetPokemon(string name)
        {
            throw new NotImplementedException();
        }

    }
}
