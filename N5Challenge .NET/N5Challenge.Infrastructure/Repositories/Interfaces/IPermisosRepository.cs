using N5Challenge.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Repositories.Interfaces
{
    public interface IPermisosRepository
    {
        Task<IEnumerable<Permisos>> ListarPermisos();
        Task<Permisos> ObtenerPermiso(int idPermiso);
    }
}
