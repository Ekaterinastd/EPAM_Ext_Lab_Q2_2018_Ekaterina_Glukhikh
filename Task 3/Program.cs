using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Realization
    {   /// <summary>
    /// Метод, вычисляющий площадь прямоугольника
    /// </summary>
    /// <returns></returns>
        public static string Square()
        {
            double x,y;
            while (true)
            {
                Console.Write("Please write the length of the first side: ");

                if (!double.TryParse(Console.ReadLine(), out x) || (x < 0))
                {
                    Console.WriteLine("Please enter positive number");
                    continue;
                }
                else break;
            }
           
            while (true)
            {
                Console.Write("Please specify the length of the second side: ");
                if (!double.TryParse(Console.ReadLine(), out y) || (y < 0))
                {
                    Console.WriteLine("Please enter positive number");
                    continue;
                }
                else break;
            }
            string s = "The square is: " + Convert.ToString(x * y);
            return s;
        }
        /// <summary>
        /// Метод, строящий прямоугольный треугольник из *
        /// </summary>
        /// <returns>изображение</returns>
        public static void Triangle()
        {
            Console.Write("Please enter the number of lines in the triangle: ");
            while (true)
            {               
                if (!int.TryParse(Console.ReadLine(), out int n) || (n < 0))
                {
                    Console.WriteLine("Please enter a positive integer");
                    continue;
                }                
                
                for (int i = 0; i < n + 1; i++)
                    for (int j = 0; j <= n; j++)
                        if (j != n)
                        {
                            if (i > j)
                                Console.Write("*");
                        }
                        else Console.Write("\n");
                break;
            }
            
        }
        /// <summary>
        /// Метод, строящий пирамиду из *
        /// </summary>
        /// <returns>изображение</returns>
        public static void Pyramid()
        {
            int line;
            Console.Write("Please enter the number of lines in the pyramid: ");
            while (true)
            {               
                if (!int.TryParse(Console.ReadLine(), out int size) || size < 0)
                {
                    Console.Write("Please enter a positive integer: ");
                    continue;
                }
                
                void drawOneLine(int spaces, int stars)
                {
                    int i;
                    for (i = 0; i < spaces; i++)
                        Console.Write(" ");
                    for (i = 0; i < stars; i++)
                        Console.Write("*");
                    Console.Write("\n");
                }
                for (line = 1; line <= size; line++)
                    drawOneLine(size - line, line * 2 - 1);
                break;
            }                       
        }
        /// <summary>
        /// Метод, рисующий ёлочку из *
        /// </summary>
        /// <returns></returns>
        public static void ChristmasTree()
        {
            Console.Write("Please enter the number of triangles: ");
            while (true)
            {                
                if(!int.TryParse(Console.ReadLine(), out int n) || n < 0)
                {
                    Console.Write("Please enter a positive integer: ");
                    continue;
                }

                for (int i = 1; i <= n + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string branch = new String('*', j);
                        Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
                    }
                }
                break;
            }
        }
        /// <summary>
        /// Метод, вычисляющий сумму натуральных чисел до 1000, кратных 3 или 5
        /// </summary>
        /// <returns></returns>
        public static string Numbers()
        {
            int sum=0;
            for (int n = 0; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                    sum += n;
             }
            var result = ("The sum of natural numbers from 1 to 1000 multiples of 3 or 5 = " + Convert.ToString(sum));
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
                Console.WriteLine(i);
            while(true)
            {
                Console.Write("Please choose the variant of font style (enter number): ");
                if((!int.TryParse(Console.ReadLine(), out int fs) || (fs != 1 && fs !=2 && fs !=3)))
                {
                    Console.WriteLine("Please enter only avalible integer");
                    continue;
                }
                if (fs == 1)
                    Console.WriteLine("Selected font style: Bold" );
                if (fs == 2)
                    Console.WriteLine("Selected font style: Italic");
                if (fs == 3)
                    Console.WriteLine("Selected font style: Underline");
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
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = r.Next(10, 99);
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
                        max = array[i, j];
                    if (min > array[i, j])
                        min = array[i, j];
                }
            }
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);

            for (i = 0; i < m; i++) //сортировка по возростанию
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
                        Console.Write(array[i, j, k] + " ");
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
                            array[i, j, k] = 0;
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
                        Console.Write(array[i, j, k] + " ");
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
            int n = 20;
            int sum = 0;
            Random r = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            for (int i = 0; i < n; i++)
                if (array[i] > 0)
                    sum += array[i];
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
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    array[i, j] = r.Next(1, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                        sum += array[i, j];
                }
            }
            Console.WriteLine("The sum of elements standing on even positions = " + sum);
        }
        /// <summary>
        /// Метод, возвращающий среднюю длину слова в строке
        /// </summary>
        public static void MediumLength()
        {
            string str = "Eat more of these soft French rolls, and have tea.";            
            double length = 0;
            Console.Write("If you want to enter your own strings, please enter 1. If you want to use the ready, enter 2 : ");
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int answer) ||((answer !=1)&& (answer != 2)))
                {
                    Console.WriteLine("Please enter 1 or 2");
                    continue;
                }
                
                if (answer == 1)
                {
                    Console.Write("Please enter the string: ");
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
            string str = "Eat more of these soft French rolls, and have tea.";
            string symb = "afternoon";          
            Console.Write("If you want to enter your own strings, please enter 1. If you want to use the ready, enter 2 : ");
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out int answer) || ((answer != 1) && (answer != 2)))
                {
                    Console.WriteLine("Please enter 1 or 2");
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

                Console.WriteLine("Result: "+  str);
                break;
            }       
                    
        }
        public static void SpeedTest()
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int num_opr = 10000;
            string[] line= new string[] { "*", "***", "******", "*********", "************" };
            
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
                Log(result+"\r\n");
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
        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }
    
    class Program
    {       
        enum Tasks
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
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("If you want choose different Task press any key, if you want to close program enter 2: ");
                if (Console.ReadLine() == Convert.ToString(2))
                    break;

                    Console.Write("Please select an assignment: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Tasks tasks = (Tasks)number;
                switch (tasks)
                {
                    case Tasks.Task1:
                        {
                              Console.WriteLine("Task1: ");
                              Console.WriteLine(Realization.Square());
                              Console.WriteLine();
                              break;
                        }

                    case Tasks.Task2:
                        {
                            Console.WriteLine("Task2: ");
                            Realization.Triangle();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task3:
                        {
                            Console.WriteLine("Task3: ");
                            Realization.Pyramid();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task4:
                        {
                            Console.WriteLine("Task4: ");
                            Realization.ChristmasTree();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task5:
                        {
                            Console.WriteLine("Task5: ");
                            Console.WriteLine(Realization.Numbers());
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task6: 
                        {
                            Console.WriteLine("Task6: ");
                            Realization.FontStyle();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task7:
                        {
                            Console.WriteLine("Task7: ");
                            Realization.Array2();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task8:
                        {
                            Console.WriteLine("Task8: ");
                            Realization.Array3();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task9:
                        {
                            Console.WriteLine("Task9: ");
                            Realization.Array1();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task10:
                        {
                            Console.WriteLine("Task10: ");
                            Realization.Array();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task11:
                        {
                            Console.WriteLine("Task11: ");
                            Realization.MediumLength();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task12:
                        {
                            Console.WriteLine("Task12: ");
                            Realization.DualCharacter();
                            Console.WriteLine();
                            break;
                        }
                    case Tasks.Task13:
                        {
                            Console.WriteLine("Task13: ");
                            Realization.SpeedTest();
                            Console.WriteLine();
                            break;
                        }

                }
        }
        }
    }
}

