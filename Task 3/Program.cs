namespace Task_3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Класс, содержащий реализацию всех методов для решения задач
    /// </summary>
    public class Solve_the_tasks
	{
        private const string Star = "*";
        private const string Space = " ";

        /// <summary>
        /// Метод, вычисляющий площадь прямоугольника
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public static string Square()
        {
            double x, y;
            while (true)
            {                
                Console.Write(Resource1.First_side);
                if (!double.TryParse(Console.ReadLine(), out x) || (x < 0))
                {
                    Console.WriteLine(Resource1.Positive_number);
                    continue;
                }
                else
                {
                    break;
                }
            }
           
            while (true)
            {
                Console.Write(Resource1.Second_side);
                if (!double.TryParse(Console.ReadLine(), out y) || (y < 0))
                {
                    Console.WriteLine(Resource1.Positive_number);
                    continue;
                }
                else
                {
                    break;
                }
            }

            string s = "The square is: " + Convert.ToString(x * y);
            return s;
        }

        /// <summary>
        /// Метод, строящий прямоугольный треугольник из *
        /// </summary>
        public static void Triangle()
        {
            Console.Write("Please enter the number of lines in the triangle: ");
            while (true)
            {               
                if (!int.TryParse(Console.ReadLine(), out int n) || (n < 0))
                {
                    Console.WriteLine(Resource1.Positive_integer);
                    continue;
                }                
                
                for (int i = 0; i < n + 1; i++)
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (j != n)
                        {
                            if (i > j)
                            {
                                Console.Write(Star); 
                            }
                        }
                        else
                        {
                            Console.Write("\n");
                        }
                    }
                }        
                
                break;
            }            
        }
                
        /// <summary>
        /// Метод, строящий пирамиду из *
        /// </summary>
        public static void Pyramid()
        {
            int line;
            Console.Write("Please enter the number of lines in the pyramid: ");
            while (true)
            {               
                if (!int.TryParse(Console.ReadLine(), out int size) || size < 0)
                {
                    Console.Write(Resource1.Positive_integer);
                    continue;
                }
                
                void drawOneLine(int Spaces, int Stars)
                {
                    int i;
                    for (i = 0; i < Spaces; i++)
                    {
                        Console.Write(Space); 
                    }       
                    
                    for (i = 0; i < Stars; i++)
                    {
                        Console.Write(Star); 
                    }

			        Console.Write("\n");
                }

                for (line = 1; line <= size; line++)
                {
                    drawOneLine(size - line, (line * 2) - 1);
                } 

                break;
            }                       
        }

        /// <summary>
        /// Метод, рисующий ёлочку из *
        /// </summary>
        public static void ChristmasTree()
        {
            Console.Write("Please enter the number of triangles: ");
            while (true)
            {                
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
                {
                    Console.Write(Resource1.Positive_integer);
                    continue;
                }

                for (int i = 1; i <= n + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string branch = new String(Convert.ToChar(Star), j); 
						Console.WriteLine(branch.PadLeft(n + 3) + Star + branch); 
					}
                }

                break;
            }
        }

        /// <summary>
        /// Метод, вычисляющий сумму натуральных чисел до 1000, кратных 3 или 5
        /// </summary>
        /// <returns>Сумма чисел</returns>
        public static string Numbers()
        {
            const int N = 1000;
            int sum = 0;
            Console.Write(Resource1.First_integer);
            int first_int = Convert.ToInt32(Console.ReadLine());
            Console.Write(Resource1.Second_integer);
            int second_int = Convert.ToInt32(Console.ReadLine());
            for (int n = 0; n < N; n++) 
			{
                if (n % first_int == 0 || n % second_int == 0) 
                {
                    sum += n;
                }					
            }

            var result = String.Format("The sum of natural numbers from 1 to 1000 multiples of {0} or {1} = {2}", first_int, second_int, Convert.ToString(sum));
            return result;
        }

        /// <summary>
        /// Метод, позволяющий выделить текстовую надпись
        /// </summary>
        public static void FontStyle()
        {
            Console.Write("Please enter a variable string: ");
            string str = Console.ReadLine();
            string[] font_style = new string[] { "1. bold", "2. italic", "3. underline" };
            foreach (string i in font_style)
            {
                Console.WriteLine(i);
            }
            
            while (true)
            {
                Console.Write("Please choose the variant of font style (enter number): ");
                if (!int.TryParse(Console.ReadLine(), out int fs) || (fs != 1 && fs != 2 && fs != 3))
                {
                    Console.WriteLine("Please enter only avalible integer");
                    continue;
                }

                if (fs == 1)
                {
                    Console.WriteLine("Selected font style: Bold");
                }
                
                if (fs == 2)
                {
                    Console.WriteLine("Selected font style: Italic");
                }
                
                if (fs == 3)
                {
                    Console.WriteLine("Selected font style: Underline");
                }
                
                break;
            }          
        }

        /// <summary>
        /// Двумерный массив, сортирующийся по возрастанию
        /// </summary>
        public static void Array2()
        {
            int m = 10;
            int n = 10;
            int i, j, t;
            int max = 0;
            int min = 100;
            int[,] array = new int[m, n];
            Random r = new Random();
            Console.Write(Resource1.Lower_bound);
            int lower_bound = Convert.ToInt32(Console.ReadLine());
            Console.Write(Resource1.Upper_bound);
            int upper_bound = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = r.Next(lower_bound, upper_bound); 
				}
            }

            Console.WriteLine("Array: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");  
                }

                Console.WriteLine();
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                    
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }                        
                }
            }

            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);

            for (i = 0; i < m; i++) ////сортировка по возростанию
            {
                for (j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        for (int p = 0; p < n; p++)
                        {
                            if (array[i, j] < array[k, p])
                            {
                                t = array[k, p];
                                array[k, p] = array[i, j];
                                array[i, j] = t;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Sort Ascending: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");                        
                }

                Console.WriteLine();
            }        
        }

        /// <summary>
        /// Трёхмерный массив, заменяющий положительные члены нулями
        /// </summary>
        public static void Array3()
        {
            int m = 5;
            int n = 5;
            int p = 5;
            int i, j, k;
            int[,,] array = new int[m, n, p];
            Random r = new Random();
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (k = 0; k < p; k++)
                    {
                        array[i, j, k] = r.Next(-9, 9); 
                    }
                }
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (k = 0; k < p; k++)
                    {
                        Console.Write(array[i, j, k] + Space);
                    }
                    
                    Console.Write("\n");
                }
                
                Console.Write("\n");
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (k = 0; k < p; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }                            
                    }
                }
            }

            Console.WriteLine("Result: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (k = 0; k < p; k++)
                    {
                        Console.Write(array[i, j, k] + Space);
                    }

                    Console.Write("\n");
                }

                Console.Write("\n");
            }
        }    
        
        /// <summary>
        /// Одномерный массив, вычисляющий сумму положительных членов
        /// </summary>
        public static void Array1()
        {
            const int n = 20;
            int sum = 0;
            Random r = new Random();
            int[] array = new int[n];
            Console.Write(Resource1.Lower_bound);
            int lower_bound = Convert.ToInt32(Console.ReadLine());
            Console.Write(Resource1.Upper_bound);
            int upper_bound = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(lower_bound, upper_bound); 
				Console.Write(array[i] + Space);
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }                    
            }
            
            Console.WriteLine();
            Console.WriteLine("sum positive numbers = " + sum);
        }

        /// <summary>
        /// Двумерный массив, для которого вычисляется сумма элементов, стоящих на чётных позициях
        /// </summary>
        public static void Array()
        {
            int m = 10;
            int n = 10;
            int i, j;
            int sum = 0;
            Random r = new Random();
            int[,] array = new int[m, n];
            Console.Write(Resource1.Lower_bound);
            int lower_bound = Convert.ToInt32(Console.ReadLine());
            Console.Write(Resource1.Upper_bound);
            int upper_bound = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = r.Next(lower_bound, upper_bound); ////todo pn хардкод
					Console.Write(array[i, j] + Space);
                }

                Console.WriteLine();
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum += array[i, j];
                    }                        
                }
            }

            Console.WriteLine("The sum of elements standing on even positions = " + sum);
        }

        /// <summary>
        /// Метод, возвращающий среднюю длину слова в строке
        /// </summary>
        public static void MediumLength()
        {
            string str = Resource1.String1;            
            double length = 0;
            Console.Write(Resource1.Select_string);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int answer) || ((answer != 1) && (answer != 2)))
                {
                    Console.WriteLine(Resource1.Correct_select);
                    continue;
                }
                
                if (answer == 1)
                {
                    Console.Write(Resource1.User_string);
                    str = Console.ReadLine();
                }

                if (answer == 2)
                {
                    Console.WriteLine(str);               
                }

                string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!char.IsLetterOrDigit(words[i][j]))
                        {
                            words[i] = words[i].Remove(j, 1);
                        }
                    }

                    length += words[i].Length;
                }

                double medium_length = length / words.Length;
                Console.WriteLine("Medium word length in this string is: " + medium_length);
                break;
            }          
        }

        /// <summary>
        /// Метод, удваивающий символы в строке
        /// </summary>
        public static void DualCharacter()
        {
            string str = Resource1.String1;
            string symb = "afternoon";          
            Console.Write(Resource1.Select_string);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int answer) || ((answer != 1) && (answer != 2)))
                {
                    Console.WriteLine(Resource1.Correct_select);
                    continue;
                }
                
                if (answer == 1)
                {
                    Console.Write("Please enter the first string: ");
                    str = Console.ReadLine();
                    Console.Write("Please enter the second string: ");
                    symb = Console.ReadLine();
                }

                if (answer == 2)
                {
                    Console.WriteLine("The first string is: " + str);
                    Console.WriteLine("The second string is: " + symb);
                }

                var charsList = new List<char>();
                foreach (var ch in symb)
                {
                    if (!charsList.Contains(ch))
                    {
                        charsList.Add(ch);
                    }
                }

                foreach (var ch in charsList)
                {
                    str = str.Replace(ch.ToString(), ch.ToString() + ch.ToString());
                }

                Console.WriteLine("Result: " + str);
                break;
            }                           
        }

/// <summary>
/// Метод, сравнивающий скорость получения строк
/// </summary>
        public static void SpeedTest()
        {
            string str = string.Empty;
            StringBuilder sb = new StringBuilder();
            int num_opr = 10000;
            string[] line = new string[] { "*", "***", "******", "*********", "************" };
            
            for (int x = 0; x < line.Length; x++)
            {
                var sw1 = Stopwatch.StartNew();
                for (int i = 0; i < num_opr; i++)
                {
                    str += line[x];
                }

                sw1.Stop();
                var sw1_Tic = sw1.ElapsedTicks;
                string result = String.Format("Test{0}: time to create a normal line: {1} ticks", (x + 1), sw1_Tic.ToString());
                Log(result + "\r\n");
                Console.WriteLine(result);

                var sw2 = Stopwatch.StartNew();
                for (int i = 0; i < num_opr; i++)
                {
                    sb.Append(line[x]);
                }

                sw2.Stop();
                var sw2_Tic = sw2.ElapsedTicks;
                result = String.Format("       time to create a string using StringBuilder: {1} ticks", (x + 1), sw2_Tic.ToString());
                Log(result + "\r\n");
                Console.WriteLine(result);
            }            
        }

        /// <summary>
        /// Метод, записывающий время создания строки в файл
        /// </summary>
        /// <param name="message">Время создания строки</param>
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }
    
    /// <summary>
    /// Класс, содержащий список всех задач и обращения к их методам
    /// </summary>
     class Program
    {       
        /// <summary>
        /// Список всех задач
        /// </summary>
        private enum Tasks
        {
            Task1 = 1,
            Task2,
            Task3,
            Task4,
            Task5,
            Task6,
            Task7,
            Task8,
            Task9,
            Task10,
            Task11,
            Task12,
            Task13
        }

        /// <summary>
        /// Метод, позволяющий пользователю выбрать задачу
        /// </summary>
        /// <param name="args">Номер задачи</param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("If you want choose different Task press any key, if you want to close program enter 2: ");
                if (Console.ReadLine() == Convert.ToString(2))
                {
                    break;
                }                    

                Console.Write("Please select an assignment: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Tasks tasks = (Tasks)number;
                switch (tasks)
                {
                    case Tasks.Task1:
                        {
                              Console.WriteLine("Task1: ");
                              Console.WriteLine(Solve_the_tasks.Square());
                              Console.WriteLine();
                              break;
                        }

                    case Tasks.Task2:
                        {
                            Console.WriteLine("Task2: ");
                            Solve_the_tasks.Triangle();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task3:
                        {
                            Console.WriteLine("Task3: ");
                            Solve_the_tasks.Pyramid();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task4:
                        {
                            Console.WriteLine("Task4: ");
                            Solve_the_tasks.ChristmasTree();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task5:
                        {
                            Console.WriteLine("Task5: ");
                            Console.WriteLine(Solve_the_tasks.Numbers());
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task6: 
                        {
                            Console.WriteLine("Task6: ");
                            Solve_the_tasks.FontStyle();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task7:
                        {
                            Console.WriteLine("Task7: ");
                            Solve_the_tasks.Array2();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task8:
                        {
                            Console.WriteLine("Task8: ");
                            Solve_the_tasks.Array3();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task9:
                        {
                            Console.WriteLine("Task9: ");
                            Solve_the_tasks.Array1();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task10:
                        {
                            Console.WriteLine("Task10: ");
                            Solve_the_tasks.Array();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task11:
                        {
                            Console.WriteLine("Task11: ");
                            Solve_the_tasks.MediumLength();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task12:
                        {
                            Console.WriteLine("Task12: ");
                            Solve_the_tasks.DualCharacter();
                            Console.WriteLine();
                            break;
                        }

                    case Tasks.Task13:
                        {
                            Console.WriteLine("Task13: ");
                            Solve_the_tasks.SpeedTest();
                            Console.WriteLine();
                            break;
                        }
                }
            }
        }
    }
}