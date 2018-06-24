namespace Task_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;

    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Task_1.Models.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {
        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        
        public class Calculating
        {
            public object X { get; set; }
            public object Y { get; set; }
                      
        }
    }

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