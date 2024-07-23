using crud_login_mvc.Data;
using crud_login_mvc.Models;

namespace crud_login_mvc.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel atualizarContato = ListaPorId(contato.id);
            if (atualizarContato == null) throw new System.Exception("Algo deu errado");
            atualizarContato.nome = contato.nome;
            atualizarContato.email = contato.email;
            atualizarContato.celular = contato.celular;

            _bancoContext.Contatos.Update(atualizarContato);
            _bancoContext.SaveChanges();
            return atualizarContato;
        }

        public bool Deletar(int id)
        {
            ContatoModel deletarContato = ListaPorId(id);
            if (deletarContato == null) throw new System.Exception("Algo deu errado");
            _bancoContext.Contatos.Remove(deletarContato);
            _bancoContext.SaveChanges();

            return true;
        }

        public ContatoModel ListaPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.id == id);
        }

        public List<ContatoModel> ListarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
