using ApiWebApi.Dtos;
using ApiWebApi.Models;
using AutoMapper;

namespace ApiWebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Dal Model al DTO e viceversa
            CreateMap<Studenti, CreateStudenteDto>().ReverseMap();
            CreateMap<Studenti, UpdateStudenteDto>().ReverseMap();
            CreateMap<Studenti, GetAllStudenteDto>().ReverseMap();
            CreateMap<Studenti, GetStudenteByIdDto>().ReverseMap();
            CreateMap<Studenti, DeleteStudenteDto>().ReverseMap();
        }
    }
}
