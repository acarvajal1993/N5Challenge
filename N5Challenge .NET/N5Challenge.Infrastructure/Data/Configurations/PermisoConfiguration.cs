using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5Challenge.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5Challenge.Infrastructure.Data.Configurations
{
    public class PermisoConfiguration : IEntityTypeConfiguration<Permisos>
    {
        public void Configure(EntityTypeBuilder<Permisos> entity)
        {
            entity.Property(e => e.ApellidoEmpleado)
          .IsRequired()
          .HasColumnType("text");

            entity.Property(e => e.FechaPermiso).HasColumnType("date");

            entity.Property(e => e.NombreEmpleado)
                .IsRequired()
                .HasColumnType("text");

            entity.HasOne(d => d.TipoPermisoNavigation)
                .WithMany(p => p.Permisos)
                .HasForeignKey(d => d.TipoPermiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permisos_TipoPermisos");
        }
    }
}
