using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalCatolicoBrasil.Models;
using System.Diagnostics;

namespace PortalCatolicoBrasil.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var dataAtual = DateOnly.FromDateTime(DateTime.Now);
            var santoDoDia = await _context.SantoDia
                .Where(s => s.Data == dataAtual)
                .FirstOrDefaultAsync();

            var viewModel = new HomeViewModel
            {
                SantoDoDia = santoDoDia
            };

            return View(viewModel);
        }

        public IActionResult Missas()
        {
            return View();
        }

        public IActionResult Liturgia()
        {
            return View();
        }

        public IActionResult Eventos()
        {
            return View();
        }

        public IActionResult SantoDia()
        {
            return View();
        }

        public IActionResult Publicacoes()
        {
            return View();
        }

        public IActionResult PrimeiraPublicacao()
        {
            return View();
        }

        public IActionResult SegundaPublicacao()
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