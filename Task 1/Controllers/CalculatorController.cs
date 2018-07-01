using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_1.Controllers
{
    public class CalculatorController : Controller
    {
        /// <summary>
        /// Метод, возвращающий сумму чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int? Sum(string X, string Y)
        {
            if (int.TryParse(X, out int x))
                if (int.TryParse(Y, out int y))
                    return x + y;
            return null;
        }
        /// <summary>
        /// Метод, возвращающий произведение чисел
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public int? Prod(string X, string Y)
        {
            if (int.TryParse(X, out int x))
                if (int.TryParse(Y, out int y))
                    return x * y;
            return null;
        }
        // GET: Calculator
        public ActionResult Calculartor(string X, string Y, string action)//todo pn что-то ты намудрила. Нужно 2 метода-экшена, которые возвращают вьюшку одну и ту же, но с разными значениями параметров модели.
        {
            int? result = null;
            switch (action)
            {
                case "+":
                    result = Sum(X, Y);
                    break;
                case "*":
                    result = Prod(X, Y);
                    break;
                default:
                    break;
            }
            if (result != null)
                Models.Expansion.log.Add(String.Format("{0}: {1} {2} {3} = {4}", DateTime.Now.ToString("dd MMMM HH:mm"), X, action, Y, result));
            return View();
        }
    }
}