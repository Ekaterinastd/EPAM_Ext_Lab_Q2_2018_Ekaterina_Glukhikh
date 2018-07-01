namespace Task_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;

    public static class Expansion
    {
        public static List<string> log = new List<string>();
        /// <summary>
        /// Метод расширения, выводящий результат вычислений
        /// </summary>
        /// <param name="html">Сообщает компилятору, что определяется метод расширения</param>
        /// <returns>Возвращает массив вычислений</returns>
        public static List<string> GetLog(this HtmlHelper html)
        {
            return log;
        }
    }
}