using ApiWebApi.Dtos;
using ApiWebApi.GenericRepositoris.Repositories;
using ApiWebApi.Models;
using AutoMapper;

namespace ApiWebApi.GenericRepositoris.Servises
{
    /// <summary>
    /// Questo servizio gestisce le operazioni CRUD per gli studenti, 
    /// utilizza un repository generico e AutoMapper per la mappatura dei dati.
    /// </summary>
    public class StudentiService
    {
        private readonly GenericRepository<Studenti> _repository;
        private readonly IMapper _mapper;

        public StudentiService(GenericRepository<Studenti> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /// <summary>
        /// Restituisce tutti gli studenti (solo dati essenziali).
        /// </summary>
        public async Task<IEnumerable<GetAllStudenteDto>> GetAllAsync()
        {
            try
            {
                IEnumerable<Studenti> studenti = await _repository.GetAllAsync();
                if (studenti == null || !studenti.Any())
                {
                    return Enumerable.Empty<GetAllStudenteDto>();
                }

                return _mapper.Map<IEnumerable<GetAllStudenteDto>>(studenti);
            }
            catch (Exception ex)
            {
                // Gestione dell'eccezione (log, rilancio, ecc.)
                throw new Exception("Errore durante il recupero degli studenti.", ex);
            }
        }

        /// <summary>
        /// Restituisce uno studente in base all'ID.
        /// </summary>
        public async Task<GetStudenteByIdDto?> GetByIdAsync(int id)
        {
            try
            {
                Studenti? studente = await _repository.GetByIdAsync(id);
                return studente != null ? _mapper.Map<GetStudenteByIdDto>(studente) : null;
            }
            catch (Exception ex)
            {
                // Gestione dell'eccezione (log, rilancio, ecc.)
                throw new Exception($"Errore durante il recupero dello studente con ID {id}.", ex);
            }
        }

        /// <summary>
        /// Crea un nuovo studente.
        /// </summary>
        public async Task<GetStudenteByIdDto> CreateAsync(CreateStudenteDto dto)
        {
            try
            {
                // Mappo DTO → Entità
                Studenti studente = _mapper.Map<Studenti>(dto);

                // Salvo con il repository
                Studenti saved = await _repository.CreateAsync(studente);

                // Ritorno DTO con Id aggiornato
                return _mapper.Map<GetStudenteByIdDto>(saved);
            }
            catch (Exception)
            {
                throw new Exception("Errore durente la creazione!");
            }
        }

        /// <summary>
        /// Aggiorna i dati di uno studente esistente.
        /// </summary>
        public async Task<GetStudenteByIdDto?> UpdateAsync(int id, UpdateStudenteDto dto)
        {
            try
            {
                if (await _repository.GetByIdAsync(id) == null)
                {
                    return null; // Studente non trovato
                }
                // Creo l'entità aggiornata
                Studenti studente = _mapper.Map<Studenti>(dto);
                studente.IdStudente = id;

                // Aggiorno con il repository
                Studenti? updated = await _repository.UpdateAsync(id, studente);

                return updated == null ? null : _mapper.Map<GetStudenteByIdDto>(updated);
            }
            catch (Exception ex)
            {
                throw new Exception("Attenzione! Errore durante la modifica", ex);
            }
        }

        /// <summary>
        /// Elimina uno studente in base all'ID.
        /// </summary>
        public async Task<bool> DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }
}
