using N5Challenge.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Core.Business.Permisos.ListarPermisos
{
    public class ListarPermisosResponse : Result
    {
        public List<PermisosResponse> Permisos { get; set; }
        public class PermisosResponse
        {
            public string NombreEmpleado { get; set; }
            public string ApellidoEmpleado { get; set; }
            public string TipoPermiso { get; set; }
            public DateTime FechaPermiso { get; set; }
            public PermisosResponse(Entities.Permisos permiso)
            {
                NombreEmpleado = permiso.NombreEmpleado;
                ApellidoEmpleado = permiso.ApellidoEmpleado;
                TipoPermiso = permiso.TipoPermisoNavigation?.Descripcion;
                FechaPermiso = permiso.FechaPermiso;
            }
        }
        public ListarPermisosResponse(IEnumerable<Entities.Permisos> permisos)
        {
            Permisos = new();
            foreach (var permiso in permisos)
                Permisos.Add(new PermisosResponse(permiso));
        }
    }
}
