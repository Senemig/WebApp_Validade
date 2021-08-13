using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp_Validade.Models;

namespace WebApp_Validade.Controllers
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
            List<Produto> lista = ListaProduto.ListarValidades();
            return View(lista);
        }

        public IActionResult CadastrarValidade()
        {
            Produto produto = new Produto();
            return View("Cadastro", produto);
        }

        public IActionResult IncluirValidade(Produto produto)
        {
            produto.dataValidade = produto.data.ToShortDateString();
            ListaProduto.AdicionarValidade(produto);
            List<Produto> lista = ListaProduto.ListarValidades();
            return View("ListaValidades", lista);
        }

        public IActionResult ListaValidades()
        {
            List<Produto> lista = ListaProduto.ListarValidades();
            return View(lista);
        }

    }
}
