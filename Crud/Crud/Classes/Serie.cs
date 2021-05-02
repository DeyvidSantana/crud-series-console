using Crud.Enums;
using System.Text;

namespace Crud.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }
        private bool excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.excluido = false;
        }

        public override string ToString()
        {
            var retorno = new StringBuilder();

            retorno.AppendLine("Gênero: " + genero);
            retorno.AppendLine("Título: " + titulo);
            retorno.AppendLine("Descrição: " + descricao);
            retorno.AppendLine("Ano de Início: " + ano);
            retorno.AppendLine("Excluído: " + excluido);

            return retorno.ToString();
        }

        public string RetornaTitulo()
        {
            return titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public bool RetornaExcluido()
        {
            return excluido;
        }

        public void Excluir()
        {
            this.excluido = true;
        }
    }
}
