using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokedex.core.Application.Interfaces.Repositories;
using Pokedex.infraestruture.Persistence.Context;
using Pokedex.infraestruture.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.infraestruture.Persistence
{
    //extencion method -- decorator pattern
    public static class ServicesRegistration
    {
        public static void AddPersistenceInfrastruture(this IServiceCollection services, IConfiguration configuration) 
        {
            #region context
            //for run database in memory 
            if (configuration.GetValue<bool>("UseInMemoryDataBase"))
            {
                services.AddDbContext<AplicationsContext>(o => o.UseInMemoryDatabase("applicationDB"));
            }
            else 
            {
                services.AddDbContext<AplicationsContext>(o => o.UseSqlServer(configuration.GetConnectionString("DefaultConection")
                    , m => m.MigrationsAssembly(typeof(AplicationsContext).Assembly.FullName)));
            }

            #endregion

            #region repositories
            services.AddTransient<IPokemonRepository, PokemonRepository>();
            services.AddTransient<IPokemonRegionRepository, PokemonRegionRepository>();
            services.AddTransient<IPokemonTypesRepository, PokemonsTypesRepositore>();
            #endregion
        }

    }
}
