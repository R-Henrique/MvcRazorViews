using Microsoft .AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    //private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();\\
    private static List<EstudanteViewModel> estudantes =
    new List<EstudanteViewModel> {
    new EstudanteViewModel(1, "Maria", "Rua M", true),
    new EstudanteViewModel(2, "João", "Rua J", true),
    new EstudanteViewModel(3, "Pedro", "Rua P", false),
    new EstudanteViewModel(4, "Carla", "Rua C", true)
    };
  public IActionResult Index()
  {
    return View(estudantes);
  }
  public IActionResult Show(int id)
  {
    return View(estudantes[id-1]);
  }
}