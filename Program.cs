// See https://aka.ms/new-console-template for more information
using AutoMapper;
using AutoMapper_teste;

Console.WriteLine("Hello, World!");

//configurando o AutoMapper
//CreateMap<origem, destino>
var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Pessoa, PessoaDto>()
                    .ForMember(dest => dest.Nome, 
                    map => map.MapFrom(from => from.Name))
                    .ReverseMap();
                    // cfg.CreateMap<PessoaDto, Pessoa>();
                    });

//Variaveis
var mapper = new Mapper(config);
var mappingProfile = new MappingProfile();
var pessoa = new Pessoa{ Id=10, Name="Fulano", Age=22, City="São Paulo", UF="SP"};
var pessoaDto = new PessoaDto{ Id=20, Nome="Ciclano", Age=44, Uf="TO"};

//Utilização Map<destino>(origem);
var pessoaToDto = mapper.Map<PessoaDto>(pessoa);
var DtoToPessoa = mapper.Map<Pessoa>(pessoaDto);

System.Console.WriteLine($"Pessoa para Dto: {pessoaToDto.ToString()}");
System.Console.WriteLine($"Dto para Pessoa: {DtoToPessoa.ToString()}");