using ApiWebApi.Dtos.Studenti;
using ApiWebApi.GenericRepositoris.Servises;
using ApiWebApi.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace ApiWebApi.Controllers
{
    [Route("api/Studenti")]
    [ApiController]
    public class StudentiController : ControllerBase
    {
        private readonly StudentiService _service;

        public StudentiController(StudentiService service)
        {
            _service = service;
        }

        /// <summary>
        /// Restituisce la lista di tutti gli studenti
        /// </summary>
        [HttpGet("List")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IEnumerable<GetAllStudenteDto> studenti = await _service.GetAllAsync();
                return Ok(ApiResponseFactory.Success(studenti, "Lista studenti recuperata con successo"));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    ApiResponseFactory.Fail<IEnumerable<GetAllStudenteDto>>("Errore interno", ex.Message));
            }
        }

        /// <summary>
        /// Restituisce uno studente per ID
        /// </summary>
        [HttpGet("GetById{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                GetStudenteByIdDto? studente = await _service.GetByIdAsync(id);
                if (studente == null)
                    return NotFound(ApiResponseFactory.Fail<GetStudenteByIdDto>($"Studente con id {id} non trovato"));

                return Ok(ApiResponseFactory.Success(studente, "Studente recuperato con successo"));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    ApiResponseFactory.Fail<GetStudenteByIdDto>("Errore interno durante la ricerca dello studente", ex.Message));
            }
        }

        /// <summary>
        /// Crea un nuovo studente
        /// </summary>
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateStudenteDto dto)
        {
            try
            {
                GetStudenteByIdDto created = await _service.CreateAsync(dto);
                return CreatedAtAction(nameof(GetById),
                    new { id = created.IdStudente },
                    ApiResponseFactory.Success(created, "Studente creato con successo"));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponseFactory.Fail<GetStudenteByIdDto>("Errore durante la creazione dello studente", ex.Message));
            }
        }

        /// <summary>
        /// Aggiorna uno studente esistente
        /// </summary>
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateStudenteDto dto)
        {
            try
            {
                GetStudenteByIdDto? updated = await _service.UpdateAsync(id, dto);
                if (updated == null)
                    return NotFound(ApiResponseFactory.Fail<GetStudenteByIdDto>($"Studente con id {id} non trovato"));

                return Ok(ApiResponseFactory.Success(updated, "Studente aggiornato con successo"));
            }
            catch (Exception ex)
            {
                return BadRequest(ApiResponseFactory.Fail<GetStudenteByIdDto>("Errore durante l'aggiornamento dello studente", ex.Message));
            }
        }

        /// <summary>
        /// Elimina uno studente
        /// </summary>
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool success = await _service.DeleteAsync(id);
                if (!success)
                    return NotFound(ApiResponseFactory.Fail<string>($"Studente con id {id} non trovato"));

                return Ok(ApiResponseFactory.Success("OK", "Studente eliminato con successo"));
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    ApiResponseFactory.Fail<string>("Errore durante l'eliminazione dello studente", ex.Message));
            }
        }
    }
}
