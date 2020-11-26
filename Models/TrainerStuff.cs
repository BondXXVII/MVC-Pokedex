using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokedexV.Models
{
    public class TrainerStuff
    {
        public int Id { get; set; }
        public string TrainerName { get; set; }
        public string TrainerImage { get; set; }
        public string Badges { get; set; }
        public virtual List<CaughtPk> Pokemans { get; set; }
    }
}