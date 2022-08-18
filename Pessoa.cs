namespace AutoMapper_teste
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UF { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            string pessoa = $"Id:{Id}; Name:{Name}; Age:{Age}; City:{City}; UF:{UF}";
            return pessoa;
        }
    }
}