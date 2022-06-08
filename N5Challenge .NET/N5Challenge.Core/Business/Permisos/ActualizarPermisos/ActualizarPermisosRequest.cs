using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Core.Business.Permisos.ActualizarPermisos
{
    public class ActualizarPermisosRequest
    {
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string TipoPermiso { get; set; }
        public DateTime? FechaPermiso { get; set; }
    }
}
