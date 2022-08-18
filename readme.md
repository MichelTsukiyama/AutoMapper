# AutoMapper

---

##

- AutoMapper (apps console);
- AutoMapper.Extensions.Microsoft.DependencyInjection (MVC e API)

## Configuração na Startup

```c#
{
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
}
```

Para injetar usar a interface ***IMapper***;

## Referências

1. https://www.youtube.com/watch?v=_ekvCMGuywg&t=621s;
2. https://www.nuget.org/packages/automapper/#readme-body-tab;
3. https://docs.automapper.org/en/latest/Understanding-your-mapping.html
