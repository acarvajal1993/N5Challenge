using N5Challenge.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Core.Business.Permisos.ActualizarPermisos
{
    public class ActualizarPermisosUseCase
    {
        private readonly Entities.Permisos permisos;
        private readonly ActualizarPermisosRequest request;
        public ActualizarPermisosUseCase(Core.Entities.Permisos permisos, ActualizarPermisosRequest request)
        {
            this.permisos = permisos;
            this.request = request;
        }
        public Result Execute()
        {
            Result result = null;
            if (permisos != null)
            {
                permisos.NombreEmpleado = request.NombreEmpleado;
                permisos.ApellidoEmpleado = request.ApellidoEmpleado;
                if (request.FechaPermiso != null)
                    permisos.FechaPermiso = request.FechaPermiso.Value;

                result = new();
            }
            else
            {
                result = new Result
                {
                    Code = Result.NOT_FOUND,
                    Type = "permiso_inexistente",
                    Message = "No se encontró el permiso"
                };
            }

            return result;
        }
    }
}
