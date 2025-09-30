using ApiWebApi.GenericRepositoris.Servises;
using Microsoft.AspNetCore.Mvc;

namespace ApiWebApi.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class StudentiController : ControllerBase
    {
        private readonly StudentiService _service;

        public StudentiController(StudentiService service)
        {
            _service = service;
        }


    }
}
