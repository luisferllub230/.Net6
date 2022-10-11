using Microsoft.EntityFrameworkCore;
using Pokedex.core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.infraestruture.Persistence.Context
{
    public class AplicationsContext : DbContext
    {
        //constructor 
        public AplicationsContext(DbContextOptions<AplicationsContext> options) : base(options) { }

        //property
        public DbSet<Pokemons>? Pokemons { get; set; }
        public DbSet<PokemonRegions>? PokemonRegions { get; set; }
        public DbSet<TypesPokemons>? TypesPokemons { get; set; }

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
            modelBuilder.Entity<Pokemons>().HasKey(Pokemons => Pokemons.id);
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
                .HasMany<Pokemons>(m => m.pokemons)
                .WithOne(p => p.typesPrimaryPokemons)
                .HasForeignKey(p => p.TypePrimaryPokemonId)
                .OnDelete(DeleteBehavior.Cascade);


            //modelBuilder.Entity<TypesPokemons>()
            //    .HasMany<Pokemons>(m => m.pokemons)
            //    .WithOne(p => p.typesSecondaryPokemons)
            //    .HasForeignKey(p => p.TypeSecondaryPokemonId)
            //    .OnDelete(DeleteBehavior.SetNull);

            #endregion


            //fluid API property configuration
            #region "property configuration"

            #region Pokemons
            modelBuilder.Entity<Pokemons>()
                .Property(p => p.pokemonName)
                .IsRequired();

            modelBuilder.Entity<Pokemons>()
                .Property(p => p.pokemonImg)
                .IsRequired();
            #endregion

            #region PokemonsRegions
            modelBuilder.Entity<PokemonRegions>()
                .Property(p => p.pokemonRegionsName)
                .IsRequired()
                .HasMaxLength(100);
            #endregion

            #region TypesPokemons
            modelBuilder.Entity<TypesPokemons>()
               .Property(p => p.typeName)
               .IsRequired()
               .HasMaxLength(100);
            #endregion

            #endregion
        }

    }
}
