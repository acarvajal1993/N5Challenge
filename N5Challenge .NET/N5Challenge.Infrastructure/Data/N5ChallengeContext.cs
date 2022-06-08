using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using N5Challenge.Core.Entities;
using N5Challenge.Infrastructure.Data.Configurations;

#nullable disable

namespace N5Challenge.Infrastructure.Data
{
    public partial class N5ChallengeContext : DbContext
    {
        public N5ChallengeContext()
        {
        }

        public N5ChallengeContext(DbContextOptions<N5ChallengeContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<TipoPermisos> TipoPermisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.ApplyConfiguration(new PermisoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoPermisosConfiguration());
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
