using ApiWebApi.Dtos.Corsi;
using ApiWebApi.Dtos.CorsiDtos;
using ApiWebApi.GenericRepositories.Servises;
using ApiWebApi.Wrappers;
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

        [HttpGet("List")]
        public async Task<ActionResult<ApiResponse<IEnumerable<GetAllCorsiDto>>>> GetAll()
        {
            try
            {
                IEnumerable<GetAllCorsiDto> corsi = await _service.GetAllAsync();
                return Ok(ApiResponseFactory.Success(corsi, "Lista corsi recuperata con successo"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponseFactory.Fail<IEnumerable<GetAllCorsiDto>>("Errore interno", ex.Message));
            }
        }

        [HttpGet("ById/{id}")]
        public async Task<ActionResult<ApiResponse<GetCorsoByIdDto>>> GetById(int id)
        {
            GetCorsoByIdDto? corso = await _service.GetByIdAsync(id);
            if (corso == null)
                return NotFound(ApiResponseFactory.Fail<GetCorsoByIdDto>($"Corso con id {id} non trovato"));

            return Ok(ApiResponseFactory.Success(corso, "Corso recuperato con successo"));
        }

        [HttpGet("{id}/studenti")]
        public async Task<ActionResult<ApiResponse<GetCorsoByIdDto>>> GetByIdWithStudenti(int id)
        {
            GetCorsoByIdDto? corso = await _service.GetCorsoByIdWithStudentiAsync(id);
            if (corso == null)
                return NotFound(ApiResponseFactory.Fail<GetCorsoByIdDto>($"Nessun corso trovato con id {id}"));

            return Ok(ApiResponseFactory.Success(corso, "Corso con studenti recuperato con successo"));
        }

        [HttpPost("Create")]
        public async Task<ActionResult<ApiResponse<GetCorsoByIdDto>>> Create([FromBody] CreateCorsoDto dto)
        {
            try
            {
                GetCorsoByIdDto created = await _service.CreateAsync(dto);
                return CreatedAtAction(nameof(GetById),
                    new { id = created.IdCorso },
                    ApiResponseFactory.Success(created, "Corso creato con successo"));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponseFactory.Fail<GetCorsoByIdDto>("Errore durante la creazione del corso", ex.Message));
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult<ApiResponse<GetCorsoByIdDto>>> Update(int id, [FromBody] UpdateCorsoDto dto)
        {
            try
            {
                GetCorsoByIdDto? updated = await _service.UpdateAsync(id, dto);
                if (updated == null)
                    return NotFound(ApiResponseFactory.Fail<GetCorsoByIdDto>($"Corso con id {id} non trovato"));

                return Ok(ApiResponseFactory.Success(updated, "Corso aggiornato con successo"));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponseFactory.Fail<GetCorsoByIdDto>("Errore durante l'aggiornamento del corso", ex.Message));
            }
        }

        [HttpDelete("Delete{id}")]
        public async Task<ActionResult<ApiResponse<string>>> Delete(int id)
        {
            try
            {
                bool success = await _service.DeleteAsync(id);
                if (!success)
                    return NotFound(ApiResponseFactory.Fail<string>($"Impossibile eliminare. Corso con id {id} non trovato"));

                return Ok(ApiResponseFactory.Success("OK", "Corso eliminato con successo"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponseFactory.Fail<string>("Errore durante l'eliminazione del corso", ex.Message));
            }
        }
    }
}
