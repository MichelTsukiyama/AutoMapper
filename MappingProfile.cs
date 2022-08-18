using AutoMapper;

namespace AutoMapper_teste
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreteMap<Origem, Destino>
            CreateMap<Pessoa, PessoaDto>()
                .ForMember(dest => dest.Nome, 
                map => map.MapFrom(from => from.Name))
                .ReverseMap();
            //CreateMap<PessoaDto, Pessoa>();
        }
    }
}