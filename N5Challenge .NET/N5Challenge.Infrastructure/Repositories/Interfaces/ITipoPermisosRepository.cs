using N5Challenge.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories.Interfaces
{
    public interface ITipoPermisosRepository
    {
        Task<IEnumerable<TipoPermisos>> ObtenerTipoPermisosEspecificos(int[] idsTipoPermisos);
    }
}
