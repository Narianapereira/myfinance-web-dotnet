using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Services;

namespace myfinance_web_netcore.Controllers
{
    [Route("[controller]")]
    public class TransactionController : Controller
    {
        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionService _transactionService;
        private readonly IAccountPlanService _accountPlanService;

        public TransactionController(
            ILogger<TransactionController> logger,
            ITransactionService transactionService,
            IAccountPlanService accountPlanService)
        {
            _logger = logger;
            _transactionService = transactionService;
            _accountPlanService = accountPlanService;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var lista = _transactionService.Listar();
            ViewBag.ListItems = lista;
            return View();
        }

        [HttpGet]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(int? id)
        {
            var transactionModel = new TransactionModel();

            if (id != null)
            {
                transactionModel = _transactionService.RetornarRegistro((int)id);
            }

            var listaAccountPlan = _accountPlanService.Listar();

            var accountPlanSelectItens = new SelectList(listaAccountPlan, "Id", "Descricao");
            transactionModel.AccountPlan = accountPlanSelectItens;
            return View(transactionModel);
        }

        [HttpPost]
        [Route("Cadastro")]
        [Route("Cadastro/{id}")]
        public IActionResult Cadastro(TransactionModel model)
        {
            _transactionService.Salvar(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            _transactionService.Excluir(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
