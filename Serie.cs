

using DIO.Series.Classes;

namespace DIO.Series
{
    public class Serie : EntidadeBase

    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        public Serie string titulo) => Titulo = titulo;

        private string Descricao { get; set; }

        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;

        }

        private int Ano { get; set; }

        private bool Excluído { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluído = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            retorno += "Excluído: " + this.Excluído;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;

        }
        public void Excluir{ } {
            this.Excluído = true
    }

}
