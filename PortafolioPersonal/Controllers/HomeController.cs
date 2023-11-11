using Microsoft.AspNetCore.Mvc;
using PortafolioPersonal.Models;
using System.Diagnostics;

namespace PortafolioPersonal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var ObjPersona = new InformacionPersonal()
            {
                Nombre = "Jader Montoya",
                Estudio = "Estudiante Desarrollo de Software",
                URL = "https://jaderm28.github.io/",

            };

            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndex() { Proyectos = proyectos, DatosPersona = ObjPersona };

            return View(modelo);
        }

        private List<InformacionProyectos> ObtenerProyectos()
        {
            return new List<InformacionProyectos>(){
            new InformacionProyectos{
                Titulo="BlackJack",
                Descripcion="Desarrollado en JavaScript Moderno",
                LinkGitHub = "https://github.com/JaderM28/BlackJack_JM.git",
                ImagenURL="./assets/blackjack-img.png",
                LinkDemo = "https://blackjack-jm.onrender.com"
            },
            new InformacionProyectos{
                Titulo="Portafolio",
                Descripcion="Desarrollado en HTML, CSS y JavaScript",
                LinkGitHub = "https://github.com/JaderM28/JaderM28.github.io.git",
                ImagenURL="./assets/portafolio-img.png",
                LinkDemo = "https://blackjack-jm.onrender.com"
            },
            new InformacionProyectos{
                Titulo="Crud Basico",
                Descripcion="Desarrollado en PHP",
                LinkGitHub = "https://github.com/JaderM28/PHPmasterCRUD.git",
                ImagenURL="./assets/crudbasico-img.png",
                LinkDemo = "https://blackjack-jm.onrender.com"
            }
        };
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}