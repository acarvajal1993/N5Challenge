using Microsoft.EntityFrameworkCore;
using N5Challenge.Core.Entities;
using N5Challenge.Infrastructure.Data;
using N5Challenge.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories
{
    public class PermisosRepository: IPermisosRepository
    {
        private readonly N5ChallengeContext context;
        public PermisosRepository(N5ChallengeContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Permisos>> ListarPermisos()
        {
            return (IEnumerable<Permisos>)await context.Permisos.ToListAsync();
        }
        public async Task<Permisos> ObtenerPermiso(int idPermiso)
        {
            return await context.Permisos.FirstOrDefaultAsync(p => p.Id == idPermiso);
        }
    }
}
