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
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["success"] = "Contato adicionado com sucesso.";
                    return RedirectToAction("Index", "Home");
                }

                return View(contato);
            }
            catch (Exception err)
            {
                TempData["error"] = $"Error ao adicionar contato. {err.Message}";
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult editarContato(int id)
        {
            ContatoModel contatoId = _contatoRepository.ListaPorId(id);
            return View(contatoId);
        }

        [HttpPost]
        public IActionResult editarContato(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Atualizar(contato);
                    TempData["success"] = "Contato atualizado com sucesso.";
                    return RedirectToAction("Index", "Home");
                }

                return View(contato);

            }
            catch (Exception err)
            {
                TempData["error"] = $"Error ao atualizar contato. {err.Message}";
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult contatoDetalhes()
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
            try
            {
                _contatoRepository.Deletar(id);
                TempData["success"] = "Contato deletado com sucesso";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception err)
            {
                TempData["error"] = $"Erro ao deletar contato {err.Message}";
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
