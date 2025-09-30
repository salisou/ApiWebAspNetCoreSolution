using ApiWebApi.Dtos;
using ApiWebApi.GenericRepositoris.Interfaces;
using ApiWebApi.Models;

namespace ApiWebApi.GenericRepositoris.Servises
{
    public class StudentiService
    {
        private readonly IGenericRepository<Studenti> _repository;

        public StudentiService(IGenericRepository<Studenti> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetAllStudenteDto>> GetAllAsync()
        {
            var studenti = await _repository.GetAllAsync();
            return studenti.Select(s => new GetAllStudenteDto
            {
                IdStudente = s.IdStudente,
                Nome = s.Nome,
                Cognome = s.Cognome
            });
        }

        public async Task<GetStudenteByIdDto?> GetByIdAsync(int id)
        {
            var studente = await _repository.GetByIdAsync(id);
            if (studente == null) return null;

            return new GetStudenteByIdDto
            {
                IdStudente = studente.IdStudente,
                Nome = studente.Nome,
                Cognome = studente.Cognome,
                Eta = studente.Eta
            };
        }

        public async Task<Studenti> CreateAsync(CreateStudenteDto dto)
        {
            var studente = new Studenti
            {
                Nome = dto.Nome,
                Cognome = dto.Cognome,
                Eta = dto.Eta
            };

            return await _repository.CreateAsync(studente);
        }

        public async Task<Studenti?> UpdateAsync(int id, UpdateStudenteDto dto)
        {
            var studente = new Studenti
            {
                IdStudente = id,
                Nome = dto.Nome,
                Cognome = dto.Cognome,
                Eta = dto.Eta
            };

            return await _repository.UpdateAsync(id, studente);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
