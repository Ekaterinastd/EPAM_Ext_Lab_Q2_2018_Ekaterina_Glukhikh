using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_1.Controllers
{
    public class CalculatorController : Controller
    {/// <summary>
    /// Метод, возвращающий сумму чисел
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
        public int Sum(int x, int y)
        {
             return x + y;
        }
        /// <summary>
        /// Метод, возвращающий произведение чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Prod(int x, int y)
        {
            return x * y;
        }
        // GET: Calculator
        public ActionResult Calculartor(Models.Model1.Calculating calc)//todo pn что-то ты намудрила. Нужно 2 метода-экшена, которые возвращают вьюшку одну и ту же, но с разными значениями параметров модели.
        {
            int selectedAction = Convert.ToInt32(Request["action"]);

            //if ((int.TryParse(Convert.ToString(calc.X), out int buf11)) & int.TryParse(Convert.ToString(calc.Y), out int buf22))
            //    if ((buf11== 0) & (buf22 == 0)) { Task_1.Models.Expansion.log.Add("Value is not integer"); return View(); }
            if ((int.TryParse(Convert.ToString(calc.X), out int buf1)) && int.TryParse(Convert.ToString(calc.Y), out int buf2))
            {
                if ((buf1 > 0) && (buf2 > 0))
                {
                        switch (selectedAction)
                        {
                            case 0:
                                {
                                    int k = Sum(buf1, buf2);
                                    Task_1.Models.Expansion.log.Add(DateTime.Now.ToString("dd MMMM HH:mm") + " " + "result: " + Convert.ToString(calc.X) + " + " + Convert.ToString(calc.Y) + " = " + Convert.ToString(k));
                                    break;
                                }
                            case 1:
                                {
                                    int k = Prod(buf1, buf2);
                                    Task_1.Models.Expansion.log.Add(DateTime.Now.ToString("dd MMMM HH:mm") + " " + "result: " + Convert.ToString(calc.X) + " * " + Convert.ToString(calc.Y) + " = " + Convert.ToString(k));
                                    break;
                                }
                        }
                }
            }
            
            return View();
        }
        public ActionResult Result(Models.Model1.Calculating calc)
        {
            return View();
        }
    }
}