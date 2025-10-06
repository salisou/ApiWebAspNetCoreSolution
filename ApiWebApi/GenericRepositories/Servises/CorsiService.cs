using ApiWebApi.Dtos.Corsi;
using ApiWebApi.Dtos.CorsiDtos;
using ApiWebApi.GenericRepositories.Repositories;
using ApiWebApi.GenericRepositoris.Repositories;
using ApiWebApi.Models;
using AutoMapper;

namespace ApiWebApi.GenericRepositories.Servises
{
    /// <summary>
    /// Questo servizio gestisce le operazioni CRUD per i corsi,
    /// utilizzando il repository generico e AutoMapper per la mappatura tra DTO ed entità.
    /// </summary>
    public class CorsiService
    {
        private readonly GenericRepository<Corsi> _repository;
        private readonly CorsiRepository _corsi;
        private readonly IMapper _mapper;

        /// <summary>
        /// Costruttore: riceve repository generico e mapper tramite Dependency Injection.
        /// </summary>
        /// <param name="repository">Repository per l'entità Corsi</param>
        /// <param name="mapper">AutoMapper per mappature DTO ↔ Entità</param>
        public CorsiService(GenericRepository<Corsi> repository, IMapper mapper, CorsiRepository corsi)
        {
            _repository = repository;
            _mapper = mapper;
            _corsi = corsi;
        }

        /// <summary>
        /// Ottiene tutti i corsi.
        /// </summary>
        /// <returns>Collezione di DTO con i corsi</returns>
        public async Task<IEnumerable<GetAllCorsiDto>> GetAllAsync()
        {
            var corsi = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<GetAllCorsiDto>>(corsi);
        }

        /// <summary>
        /// Ottiene un corso per ID.
        /// </summary>
        /// <param name="id">ID del corso</param>
        /// <returns>DTO del corso se esiste, altrimenti null</returns>
        public async Task<GetCorsoByIdDto?> GetByIdAsync(int id)
        {
            Corsi? corso = await _repository.GetByIdAsync(id);
            return corso != null ? _mapper.Map<GetCorsoByIdDto>(corso) : null;
        }

        // Dettaglio corso con studenti
        public async Task<GetCorsoByIdDto?> GetCorsoByIdWithStudentiAsync(int id)
        {
            var corso = await _corsi.GetByIdWithStudentiAsync(id);
            return corso != null ? _mapper.Map<GetCorsoByIdDto>(corso) : null;
        }

        /// <summary>
        /// Crea un nuovo corso.
        /// </summary>
        /// <param name="dto">DTO con i dati del corso da creare</param>
        /// <returns>DTO del corso creato con ID assegnato</returns>
        public async Task<GetCorsoByIdDto> CreateAsync(CreateCorsoDto dto)
        {
            // AutoMapper si occupa di convertire array di int in GiorniSettimana
            Corsi corso = _mapper.Map<Corsi>(dto);

            // Salva con il repository
            Corsi saved = await _repository.CreateAsync(corso);

            // Ritorna DTO dettagliato
            return _mapper.Map<GetCorsoByIdDto>(saved);
        }

        /// <summary>
        /// Aggiorna un corso esistente.
        /// </summary>
        /// <param name="id">ID del corso da aggiornare</param>
        /// <param name="dto">DTO con i dati aggiornati</param>
        /// <returns>DTO aggiornato se trovato, altrimenti null</returns>
        public async Task<GetCorsoByIdDto?> UpdateAsync(int id, UpdateCorsoDto dto)
        {
            Corsi? existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return null;

            Corsi corso = _mapper.Map<Corsi>(dto);
            corso.IdCorso = id;

            Corsi? updated = await _repository.UpdateAsync(id, corso);
            return updated != null ? _mapper.Map<GetCorsoByIdDto>(updated) : null;
        }

        /// <summary>
        /// Elimina un corso in base al suo ID.
        /// </summary>
        /// <param name="id">ID del corso da eliminare</param>
        /// <returns>True se l'eliminazione è riuscita, altrimenti False</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
