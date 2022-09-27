using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class AplicationsContext : DbContext
    {
        //constructor 
        public AplicationsContext(DbContextOptions<AplicationsContext> options) : base(options) { }

        //property
        DbSet<Pokemons> Pokemons { get; set; }
        DbSet<PokemonRegions> PokemonRegions { get; set; }
        DbSet<TypesPokemons> TypesPokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //fluent API name tables 
            #region tables
            modelBuilder.Entity<Pokemons>().ToTable("Pokemons");
            modelBuilder.Entity<PokemonRegions>().ToTable("PokemonRegions");
            modelBuilder.Entity<TypesPokemons>().ToTable("TypesPokemons");
            #endregion

            //fluent API primary key
            #region primary key
            modelBuilder.Entity<Pokemons>().HasKey( Pokemons => Pokemons.id);
            modelBuilder.Entity<PokemonRegions>().HasKey(PokemonRegions => PokemonRegions.id);
            modelBuilder.Entity<TypesPokemons>().HasKey(TypesPokemons => TypesPokemons.id);
            #endregion

            //fluid API relationships
            #region relationships
            modelBuilder.Entity<PokemonRegions>()
                .HasMany<Pokemons>(PokemonRegions => PokemonRegions.pokemons)
                .WithOne(Pokemons => Pokemons.pokemonRegions)
                .HasForeignKey(Pokemons => Pokemons.pokemonRegionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TypesPokemons>()
                .HasMany(TypesPokemons => TypesPokemons.pokemons)
                .WithOne(Pokemons => Pokemons.typesPrimaryPokemons)
                .HasForeignKey(Pokemons => Pokemons.TypePrimaryPokemonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TypesPokemons>()
                .HasMany(TypesPokemons => TypesPokemons.pokemons)
                .WithOne(Pokemons => Pokemons.TypesSecondaryPokemons)
                .HasForeignKey(Pokemons => Pokemons.TypeSecondaryPokemonId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }

    }
}
