using Microsoft.AspNetCore.Mvc;
using MVC2022.Repositories.Interfaces;
using MVC2022.ViewModels;

namespace MVC2022.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository repository)
        {
            _lancheRepository = repository;
        }

        public IActionResult List()
        {
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lancheListViewModel);




        }
    }
}
