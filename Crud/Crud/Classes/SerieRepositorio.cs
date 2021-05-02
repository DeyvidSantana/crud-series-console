using Crud.Interfaces;
using System.Collections.Generic;

namespace Crud.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private IList<Serie> listaSeries = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            listaSeries[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Incluir(Serie entidade)
        {
            listaSeries.Add(entidade);
        }

        public IList<Serie> Listar()
        {
            return listaSeries;
        }

        public Serie ObterPorId(int id)
        {
            return listaSeries[id];
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }
    }
}
