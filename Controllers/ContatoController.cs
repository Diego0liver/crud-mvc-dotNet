using crud_login_mvc.Models;
using crud_login_mvc.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crud_login_mvc.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult novoContato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NovoContato(ContatoModel contato)
        {
            _contatoRepository.Adicionar(contato);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult editarContato(int id)
        {
            ContatoModel contatoId = _contatoRepository.ListaPorId(id);
            return View(contatoId);
        }

        [HttpPost]
        public IActionResult EditarContato(ContatoModel contato)
        {
            _contatoRepository.Atualizar(contato);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult contatoDetalhes()
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {  
            _contatoRepository.Deletar(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
