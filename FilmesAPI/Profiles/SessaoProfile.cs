using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using AutoMapper;

namespace FilmesAPI.Profiles 
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }        
    }
}
