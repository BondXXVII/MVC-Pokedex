using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokedexV.Models
{
    public class CaughtPk
    {
        public int Id { get; set; }
        public string CaughtName { get; set; }
        public int CaughtDexNum { get; set; }
        public virtual List<Pokemon> Pokemins { get; set; }
        public virtual TrainerStuff Trainer { get; set; }
    }
}