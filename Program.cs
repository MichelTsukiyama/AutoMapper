using AutoMapper;
using AutoMapper_teste;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static AutoMapper.QuickType;

//configurando o AutoMapper
//CreateMap<origem, destino>
var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Pessoa, PessoaDto>()
                    .ForMember(dest => dest.Nome, 
                    map => map.MapFrom(from => from.Name))
                    .ReverseMap();
                    cfg.CreateMap<JObject, PessoaDto>()
                    .ReverseMap();
                    cfg.CreateMap<JArray, Pessoa>()
                    .ReverseMap();
                    cfg.CreateMap<QuickType, PessoaDto>()
                    .ReverseMap();
                    // cfg.CreateMap<PessoaDto, Pessoa>();
                    });

//Variaveis
var mapper = new Mapper(config);
var mappingProfile = new MappingProfile();
var pessoa = new Pessoa{ Id=10, Name="Fulano", Age=22, City="São Paulo", UF="SP"};
var pessoaDto = new PessoaDto{ Id=20, Nome="Ciclano", Age=44, Uf="TO"};


#region  Mapper Teste

//Utilização Map<destino>(origem);
var pessoaToDto = mapper.Map<PessoaDto>(pessoa);
var DtoToPessoa = mapper.Map<Pessoa>(pessoaDto);

System.Console.WriteLine($"Pessoa para Dto: {pessoaToDto.ToString()}");
System.Console.WriteLine($"Dto para Pessoa: {DtoToPessoa.ToString()}");

#endregion

string body = new StreamReader("./file.json").ReadToEnd();

var welcome = Welcome.FromJson(body);

Pessoa pessoaJson = JsonConvert.DeserializeObject<Pessoa>(body);
PessoaDto pessoaDtoJson = JsonConvert.DeserializeObject<PessoaDto>(body);
System.Console.WriteLine($"Pessoa : {pessoaJson}");
System.Console.WriteLine($"PessoaDto : {pessoaDtoJson}");

var file = JsonConvert.SerializeObject(pessoaJson);
File.WriteAllText("./src/teste.json", file);

var jsonReader = mapper.Map<JObject>(pessoaDtoJson);
var jsonReader2 = mapper.Map<JArray>(pessoaJson);
File.WriteAllText("./src/testeDto.json", jsonReader.ToString());
File.WriteAllText("./src/testePessoa.json", jsonReader2.ToString());

var jsonReader3 = mapper.Map<QuickType>(pessoaDtoJson);
File.WriteAllText("./src/testeDto.json", jsonReader3.ToString());


