using Microsoft.EntityFrameworkCore;
using N5Challenge.Core.Entities;
using N5Challenge.Infrastructure.Data;
using N5Challenge.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories
{
    public class TipoPermisosRepository : ITipoPermisosRepository
    {
        private readonly N5ChallengeContext context;
        public TipoPermisosRepository(N5ChallengeContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<TipoPermisos>> ObtenerTipoPermisosEspecificos(int[] idsTipoPermisos)
        {
            return await context.TipoPermisos.Where(tp => idsTipoPermisos.Contains(tp.Id)).ToListAsync();
        }
    }
}
