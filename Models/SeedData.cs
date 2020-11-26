using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PokedexV.Data;
using System;
using System.Linq;

namespace PokedexV.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokedexVContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PokedexVContext>>()))
            {
                // Look for any Pokemons.
                
                if (context.Pokemon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pokemon.AddRange(
                    new Pokemon
                    {
                        Id = 1,
                        Name = "Bulbasaur",
                        Type = "Grass / Poison",
                        Text = "There is a plant seed on its back right from the day this Pokémon is born. The seed slowly grows larger.",
                        Evolve = "Evolves at lvl 16 into Ivysaur",
                        Image = "https://www.serebii.net/swordshield/pokemon/001.png"
                    },

                    new Pokemon
                    {
                        Id = 2,
                        Name = "Ivysaur",
                        Type = "Grass / Poison",
                        Text = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.",
                        Evolve = "Evolves at lvl 32 into Venusaur",
                        Image = "https://www.serebii.net/swordshield/pokemon/002.png"
                    },

                    new Pokemon
                    {
                        Id = 3,
                        Name = "Venusaur",
                        Type = "Grass / Poison",
                        Text = "Its plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
                        Evolve = "Does not evolve",
                        Image = "https://www.serebii.net/swordshield/pokemon/003.png"
                    },

                    new Pokemon
                    {
                        Id = 4,
                        Name = "Charmander",
                        Type = "Fire",
                        Text = "From the time it is born, a flame burns at the tip of its tail. Its life would end if the flame were to go out.",
                        Evolve = "Evolves at lvl 16 into Charmeleon",
                        // Image = "https://www.pkparaiso.com/imagenes/xy/sprites/animados/charmander.gif"
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/charmander.gif"
                    },

                    new Pokemon
                    {
                        Id = 5,
                        Name = "Charmeleon",
                        Type = "Fire",
                        Text = "If it becomes agitated during battle, it spouts intense flames, incinerating its surroundings.",
                        Evolve = "Evolves at lvl 36 into Charizard",
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/charmeleon.gif"
                    },

                    new Pokemon
                    {
                        Id = 6,
                        Name = "Charizard",
                        Type = "Fire / Flying",
                        Text = "It spits fire that is hot enough to melt boulders. It may cause forest fires by blowing flames.",
                        Evolve = "Does not evolve",
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/charizard.gif"
                    },

                    new Pokemon
                    {
                        Id = 7,
                        Name = "Squirtle",
                        Type = "Water",
                        Text = "When it feels threatened, it draws its limbs inside its shell and sprays water from its mouth.",
                        Evolve = "Evolves at lvl 16 into Wartortle",
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/squirtle.gif"
                    },

                    new Pokemon
                    {
                        Id = 8,
                        Name = "Wartortle",
                        Type = "Water",
                        Text = "It cleverly controls its furry ears and tail to maintain its balance while swimming.",
                        Evolve = "Evolves at lvl 36 into Blastoise",
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/wartortle.gif"
                    },

                    new Pokemon
                    {
                        Id = 9,
                        Name = "Blastoise",
                        Type = "Water",
                        Text = "The rocket cannons on its shell fire jets of water capable of punching holes through thick steel.",
                        Evolve = "Does not evolve",
                        Image = "https://www.pkparaiso.com/imagenes/espada_escudo/sprites/animados-gigante/blastoise.gif"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}