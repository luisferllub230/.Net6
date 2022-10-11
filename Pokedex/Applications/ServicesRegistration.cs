using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokedex.core.Application.Interfaces.Repositories;
using Pokedex.core.Application.Interfaces.Services;
using Pokedex.core.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.core.Application
{
    //extencion method -- decorator pattern
    public static class ServicesRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services) 
        {
            #region repositories
            services.AddTransient<IPokemonTypeServices, PokemonsTypesServices>();
            services.AddTransient<IPokemonServices, PokemonServices>();
            services.AddTransient<IPokemonRegionServices, PokemonRegionServices>();
            #endregion
        }

    }
}
