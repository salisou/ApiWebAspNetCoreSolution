using ApiWebApi.Data;
using ApiWebApi.Dtos.Studenti;
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
        private readonly ApiWebContext _context;
        private readonly GenericRepository<Studenti> _repository;
        private readonly IMapper _mapper;

        public StudentiService(GenericRepository<Studenti> repository, IMapper mapper, ApiWebContext context)
        {
            _repository = repository;
            _mapper = mapper;
            _context = context;
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
            // Controllo che il corso esista
            Corsi? corso = await _context.Corsi.FindAsync(dto.IdCorso);
            if (corso == null)
                throw new Exception($"Il corso con Id {dto.IdCorso} non esiste.");

            // Mappo DTO → Entità
            Studenti studente = _mapper.Map<Studenti>(dto);

            // Salvo con il repository
            Studenti saved = await _repository.CreateAsync(studente);

            // Ritorno DTO con Id aggiornato
            return _mapper.Map<GetStudenteByIdDto>(saved);
        }

        /// <summary>
        /// Aggiorna i dati di uno studente esistente.
        /// </summary>
        public async Task<GetStudenteByIdDto?> UpdateAsync(int id, UpdateStudenteDto dto)
        {
            try
            {
                // Recupera lo studente esistente
                var existing = await _repository.GetByIdAsync(id);
                if (existing == null)
                    return null;

                // Controlla che il corso esista
                var corso = await _context.Corsi.FindAsync(dto.IdCorso);
                if (corso == null)
                    throw new Exception($"Il corso con Id {dto.IdCorso} non esiste.");

                // Aggiorna manualmente le proprietà
                existing.Nome = dto.Nome;
                existing.Cognome = dto.Cognome;
                existing.Eta = dto.Eta;
                existing.IdCorso = dto.IdCorso;

                // Salva l'aggiornamento
                var updated = await _repository.UpdateAsync(id, existing);

                return _mapper.Map<GetStudenteByIdDto>(updated);
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
