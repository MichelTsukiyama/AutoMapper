namespace AutoMapper_teste
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Age { get; set; }
        public string? Uf { get; set; }

                public override string ToString()
        {
            string pessoa = $"Id:{Id}; Nome:{Nome}; Age:{Age}; Uf:{Uf}";
            return pessoa;
        }
    }
}