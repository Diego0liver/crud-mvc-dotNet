using crud_login_mvc.Models;

namespace crud_login_mvc.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        ContatoModel ListaPorId(int id);
        bool Deletar(int id);
    }
}
