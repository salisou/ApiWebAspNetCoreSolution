using ApiWebApi.GenericRepositories.Servises;
using Microsoft.AspNetCore.Mvc;

namespace ApiWebApi.Controllers
{
    [Route("api/Corso")]
    [ApiController]
    public class CorsiController : ControllerBase
    {
        private readonly CorsiService _service;

        public CorsiController(CorsiService service)
        {
            _service = service;
        }


    }
}
