using System.Collections.Generic;

namespace Crud.Interfaces
{
    public interface IRepositorio<T>
    {
        IList<T> Listar();
        T ObterPorId(int id);
        void Incluir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
