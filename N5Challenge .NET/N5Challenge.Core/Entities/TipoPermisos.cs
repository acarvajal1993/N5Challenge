using System;
using System.Collections.Generic;

#nullable disable

namespace N5Challenge.Core.Entities
{
    public partial class TipoPermisos
    {
        public TipoPermisos()
        {
            Permisos = new HashSet<Permisos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Permisos> Permisos { get; set; }
    }
}
