namespace MensagensNPS.Models
{
    public class Template
    {
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataExclusao { get; set; }

        public Template(string nome, string conteudo)
        {
            Nome = nome;
            Conteudo = conteudo;
            DataCadastro = DateTime.Now;
        }
    }
}
