using System;
using System.ComponentModel.DataAnnotations;

namespace PokedexV.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Evolve { get; set; }
    }
}