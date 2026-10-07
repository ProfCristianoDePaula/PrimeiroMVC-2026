using Microsoft.AspNetCore.Mvc;

namespace PrimeiroMVC.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            // Acao para exibir uma pagina com a  lista de carros
            return View();
        }

        public IActionResult Cadastrar()
        {
            // Acao para exibir a pagina de cadastro de carros
            return View();
        }
    }
}
