using Microsoft.AspNetCore.Mvc;
using N5Challenge.Core.Business.Permisos.ActualizarPermisos;
using N5Challenge.Core.Business.Permisos.ListarPermisos;
using N5Challenge.Infrastructure.Repositories.Interfaces;
using N5Challenge.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5Challenge.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PermisosControlller : BaseController
    {
        private readonly IBaseRepository baseRepository;
        private readonly IPermisosRepository permisosRepository;
        private readonly ITipoPermisosRepository tipoPermisosRepository;

        public PermisosControlller(IBaseRepository baseRepository,
            IPermisosRepository permisosRepository,
            ITipoPermisosRepository tipoPermisosRepository)
        {
            this.baseRepository = baseRepository;
            this.permisosRepository = permisosRepository;
            this.tipoPermisosRepository = tipoPermisosRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ListarPermisos()
        {
            //Obtenemos el estado
            var persmisos = await permisosRepository.ListarPermisos();
            if (persmisos != null && persmisos.Count() > 0)
                await tipoPermisosRepository.ObtenerTipoPermisosEspecificos(persmisos.Select(p => p.Id).ToArray());

            return ResultResponse(new ListarPermisosResponse(persmisos));
        }

        [HttpPut("idPermiso")]
        public async Task<IActionResult> ActualizarPermiso(int idPermiso, [FromBody] ActualizarPermisosRequest request)
        {
            //Obtenemos el estado
            var permiso = await permisosRepository.ObtenerPermiso(idPermiso);

            //Procesamos
            var useCase = new ActualizarPermisosUseCase(permiso, request);
            var result = useCase.Execute();

            //Validamos respuesta
            if (result.Code == Result.OK)
                await baseRepository.SaveChangesAsync();

            return ResultResponse(result);
        }
    }
}
