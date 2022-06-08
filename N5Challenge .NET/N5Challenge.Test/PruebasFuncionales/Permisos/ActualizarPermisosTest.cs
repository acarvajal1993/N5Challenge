using N5Challenge.Core.Business.Permisos.ActualizarPermisos;
using N5Challenge.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace N5Challenge.Test.PruebasFuncionales.Permisos
{
    public class ActualizarPermisosTest
    {
        [Fact]
        public void ActualizarPermisosCorrecto()
        {
            var request = new ActualizarPermisosRequest
            {
                NombreEmpleado = "Jose",
                ApellidoEmpleado = "Pérez"
            };

            Core.Entities.Permisos permisos = new()
            {
                NombreEmpleado = "Argenis",
                ApellidoEmpleado = "Carvajal"
            };

            var useCase = new ActualizarPermisosUseCase(permisos, request);
            var result = useCase.Execute();

            Assert.Equal(result.Code, Result.OK);
        }

        [Fact]
        public void ActualizarPermisosIncorrecto()
        {
            var request = new ActualizarPermisosRequest
            {
                NombreEmpleado = "Jose",
                ApellidoEmpleado = "Pérez"
            };

            Core.Entities.Permisos permisos = null;

            var useCase = new ActualizarPermisosUseCase(permisos, request);
            var result = useCase.Execute();

            Assert.Equal(result.Code, Result.NOT_FOUND);
        }
    }
}
