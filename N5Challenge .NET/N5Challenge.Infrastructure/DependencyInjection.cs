using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using N5Challenge.Infrastructure.Data;
using N5Challenge.Infrastructure.Repositories;
using N5Challenge.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<N5ChallengeContext>(options => options.UseSqlServer(configuration.GetConnectionString("N5ChallengeEntities")));
            services.AddScoped<IPermisosRepository, PermisosRepository>();
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<ITipoPermisosRepository, TipoPermisosRepository>();
            return services;
        }
    }
}
