using System;
using System.Collections.Generic;

#nullable disable

namespace N5Challenge.Core.Entities
{
    public partial class Permisos
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public int TipoPermiso { get; set; }
        public DateTime FechaPermiso { get; set; }
        public virtual TipoPermisos TipoPermisoNavigation { get; set; }
    }
}
