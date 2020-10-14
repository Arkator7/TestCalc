using Microsoft.AspNetCore.Mvc;
using TestCalc.Models;

namespace TestCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index( Operation model )
        {
            switch (model.OperationType)
            {
                case OperationType.Addition:
                    model.Result = model.FirstNumber + model.SecondNumber;
                    break;
                case OperationType.Subtraction:
                    model.Result = model.FirstNumber - model.SecondNumber;
                    break;
                case OperationType.Multiplication:
                    model.Result = model.FirstNumber * model.SecondNumber;
                    break;
                case OperationType.Division:
                    model.Result = model.FirstNumber / model.SecondNumber;
                    break;
            }

            return View( model );
        }
    }
}