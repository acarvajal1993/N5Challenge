using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N5Challenge.Core.Entities;

namespace N5Challenge.Infrastructure.Data.Configurations
{
    public class TipoPermisosConfiguration : IEntityTypeConfiguration<TipoPermisos>
    {
        public void Configure(EntityTypeBuilder<TipoPermisos> entity)
        {
            entity.Property(e => e.Descripcion)
            .IsRequired()
            .HasColumnType("text");
        }
    }
}
