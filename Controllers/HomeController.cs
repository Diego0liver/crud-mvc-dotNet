using crud_login_mvc.Models;
using crud_login_mvc.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crud_login_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepository _contatoRepositoryHome;
        public HomeController(IContatoRepository contatoRepository)
        {
            _contatoRepositoryHome = contatoRepository;
        }

        public IActionResult Index()
        {
            var contatos = _contatoRepositoryHome.ListarTodos();
            return View(contatos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
