using ApiWebApi.Dtos.Corsi;
using ApiWebApi.Dtos.CorsiDtos;
using ApiWebApi.Dtos.Studenti;
using ApiWebApi.Models;
using AutoMapper;


namespace ApiWebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // ===============================
            // Mapping Studenti
            // ===============================
            CreateMap<Studenti, CreateStudenteDto>().ReverseMap();   // Studente ↔ CreateStudenteDto (bidirezionale)
            CreateMap<Studenti, UpdateStudenteDto>().ReverseMap();   // Studente ↔ UpdateStudenteDto (bidirezionale)
            CreateMap<Studenti, GetAllStudenteDto>();                // Studente → GetAllStudenteDto (solo lettura)
            CreateMap<Studenti, GetStudenteByIdDto>();               // Studente → GetStudenteByIdDto (dettaglio singolo)
            CreateMap<Studenti, GetStudenteInCorsoDto>();            // Studente → GetStudenteInCorsoDto (studente dentro un corso)
            CreateMap<Studenti, DeleteStudenteDto>().ReverseMap();   // Studente ↔ DeleteStudenteDto (bidirezionale)


            // ===============================
            // Mapping Corsi
            // ===============================
            // Mapping da CreateCorsoDto a entità Corsi
            CreateMap<CreateCorsoDto, Corsi>()                       // Mapping DTO creazione → Entità Corso
                .ForMember(dest => dest.Giorni,                      // Configura il campo Giorni
                    opt => opt.MapFrom(src =>                        // Prende array di int dal DTO
                        src.Giorni.Aggregate((GiorniSettimana)0,     // Parte da enum vuoto (0)
                            (acc, g) => acc | (GiorniSettimana)g)    // Combina con bitwise OR i giorni
                    ));

            // Mapping da UpdateCorsoDto a entità Corsi
            CreateMap<UpdateCorsoDto, Corsi>()
                .ForMember(dest => dest.Giorni,
                    opt => opt.MapFrom(src =>
                        src.Giorni.Aggregate((GiorniSettimana)0,         // Stessa logica del Create
                            (acc, g) => acc | (GiorniSettimana)g)
                    ));

            // Mapping da Corsi a GetAllCorsiDto (visualizzazione tabellare/lista)
            CreateMap<Corsi, GetAllCorsiDto>();


            // Mapping da Corsi a GetCorsoByIdDto (dettaglio corso con studenti e giorni)
            CreateMap<Corsi, GetCorsoByIdDto>()
                .ForMember(dest => dest.Studenti,                        // Mappa la lista degli studenti collegati al corso
                    opt => opt.MapFrom(src => src.Studenti))
                .ForMember(dest => dest.Giorni,                          // Converte il campo Giorni enum → array di int
                    opt => opt.MapFrom(src =>
                        Enum.GetValues(typeof(GiorniSettimana))          // Prende tutti i valori dell’enum GiorniSettimana
                            .Cast<GiorniSettimana>()                     // Li converte in oggetti enum
                            .Where(g => g != 0 && src.Giorni.HasFlag(g)) // Filtra solo quelli effettivamente presenti nel corso
                            .Select(g => (int)g)                         // Li converte in interi (1,2,3…)
                            .ToArray()));

        }
    }
}
