using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    class Program
    {
        #region 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        /// <summary>
        /// Метод, принимающий число и матрицу, возвращающий матрицу умноженную на число.
        /// </summary>
        /// <param name="lambda">Вещественный множитель.</param>
        /// <param name="matrix">Вещественная матрица размера с n строками, m столбцами.</param>
        /// <returns>Возвращает матрицу, умноженную на число.</returns>
        public static double[,] LambdaMatrixMultiplier(double lambda, double[,] matrix)
        {
            double[,] lambdaMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    lambdaMatrix[i, j] = lambda * matrix[i, j];
                }
            }
            return lambdaMatrix;
        }

        #endregion

        #region 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму
        /// <summary>
        /// Метод, принимающий две матрицы, возвращающий их сумму.
        /// </summary>
        /// <param name="matrixA">Вещественная матрица размера с n строками, m столбцами.</param>
        /// <param name="matrixB">Вещественная матрица размера с n строками, m столбцами.</param>
        /// <returns>Возвращает сумму двух матриц-аргументов.</returns>
        public static double[,] MatrixMatrixSumm(double[,] matrixA, double[,] matrixB)
        {
            double[,] matrixSum = new double[matrixA.GetLength(0), matrixA.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    matrixSum[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return matrixSum;
        }


        #endregion

        #region 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение
        /// <summary>
        /// Метод, принимающий две матрицы, возвращающий их произведение.
        /// </summary>
        /// <param name="matrixA">Вещественная матрица размера с n строками, m столбцами.</param>
        /// <param name="matrixB">Вещественная матрица размера с m строками, k столбцами.</param>
        /// <returns>Возвращает вещественную матрицу с n строками, k столбцами - произведение матриц-аргументов.</returns>
        public static double[,] MatrixMatrixMultiplier(double[,] matrixA, double[,] matrixB)
        {
            double[,] matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int s = 0; s < matrixB.GetLength(0); s++)
                    {
                        matrixC[i, j] = matrixC[i, j] + matrixA[i, s] * matrixB[s, j];
                    }
                }
            }
            return matrixC;
        }
        #endregion

        /// <summary>
        /// Метод, генерирующий случайную вещественную матрицу.
        /// </summary>
        /// <param name="rnd">ГПСЧ</param>
        /// <param name="n">Количество строк в первой матрице</param>
        /// <param name="m">Количество столбцов в первой матрице</param>
        /// <param name="a">Нижняя граница значений элементов матрицы</param>
        /// <param name="b">Верхняя граница значений элементов матрицы -1</param>
        /// <returns>Возвращает случайную вещественную матрицу размером n * m</returns>
        public static double[,] GenerateRandomMatrix(Random rnd, int n, int m, int a, int b)
        {

            double[,] randMatrix = new double[n, m];

            for (int i = 0; i < randMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randMatrix.GetLength(1); j++)
                {
                    randMatrix[i, j] = rnd.Next(a, b);
                }
            }
            return randMatrix;
        }

        /// <summary>
        /// Метод, выводящий матрицу на экран.
        /// </summary>
        /// <param name="matrix">Матрица, которую нужно вывести</param>
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        #region             // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв

        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД


        
        public static void printString(string text)
        {
            string[] subs = text.Split();
            foreach (string item in subs)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //Разбить строку на подстроки, отсортировать их по длине.

        public static string getMinimalLengthWord(string text)
        {
            string[] subs = text.Split();

            for (int i = 0; i < subs.Length; i++)
            {
                for (int j = i+1; j < subs.Length; j++)
                {
                    if (subs[i].Length > subs[j].Length)
                    {
                        string tmp = " ";
                        tmp = subs[i];
                        subs[i] = subs[j];
                        subs[j] = tmp;
                    }
                }
            }
            return subs[0];
        }


        #endregion

        #region         // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // Ответ: ГГГГ, ДДДД
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой)

        //TO DO: возвращать все слова с максимальным количеством букв.

        public static string getMaxLengthWord(string text)
        {
            string[] subs = text.Split();

            for (int i = 0; i < subs.Length; i++)
            {
                for (int j = i + 1; j < subs.Length; j++)
                {
                    if (subs[i].Length < subs[j].Length)
                    {
                        string tmp = " ";
                        tmp = subs[i];
                        subs[i] = subs[j];
                        subs[j] = tmp;
                    }
                }
            }
            Array.Reverse(subs);
            return subs[subs.Length-1];
        }


        #endregion


        #region  Проверка на прогрессию.
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить  
        //  является заданная последовательность элементами арифметической или геометрической прогрессии

        public static void isProgression(params double[] nums)
        {
            bool isArithmetic = false;
            bool isGeometric = false;
            double d = (nums[nums.Length - 1] - nums[0]) / (nums.Length - 1); 
            double ratio = nums[1] / nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length-1; j++)
                {
                    if(nums[0]!=0)
                    {
                        d = (nums[nums.Length - 1] - nums[0]) / (nums.Length - 1);

                        if ((nums[j - 1] + nums[j + 1]) * 0.5 == nums[j])
                            {
                                isArithmetic = true;
                            }
                        else
                            {
                                isArithmetic = false;
                            }   
                    }
                    if(nums[0]==0)
                    {
                        d = (nums[nums.Length - 1] / nums[1]) / (nums.Length - 2);
                        
                            if ((nums[j - 1] + nums[j + 1]) * 0.5 == nums[j])
                            {
                                isArithmetic = true;
                            }
                            else
                            {
                                isArithmetic = false;
                            }
                    }
                    if(Math.Sqrt(nums[j-1]*nums[j+1])==nums[j])
                    {
                        isGeometric = true;
                    }
                    else
                    {
                        isGeometric = false;
                    }
                }
            }
            if (isArithmetic)
            {
                Console.WriteLine("Arithmetic");
            }
            if (isGeometric)
            {
                Console.WriteLine("Geometric");
            }
            if(!isArithmetic && !isGeometric)
            {
                Console.WriteLine("Not arithmetic and not geometric");
            }
        }




        #endregion


        #region Функция Аккермана

        /*
         * 
         *  // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
         * 
         * */


            static int Ackermann (int n, int m)
        {

            return (n == 0) ? (m + 1) : ((m == 0) ? (Ackermann(n - 1, 1)) : Ackermann(n - 1, Ackermann(n, m - 1))); 
        }


        #endregion



        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n; //Количество строк в первой матрице.
            int m; //Количество столбцов в первой матрице
            int k; //Количество столбцов во второй матрице (для умножения)

            double lambda; //Вещественный множитель

            #region commented matrix

            

            Console.WriteLine("Enter number of rows \'n\' (non negative): ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Incorrect \'n\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns \'m\' (non negative): ");
            m = Convert.ToInt32(Console.ReadLine());

            while (m <= 0)
            {
                Console.WriteLine("Incorrect \'m\'. Try again.");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter number of columns in 2nd matrix for multiplying\'k\' (non negative): ");
            k = Convert.ToInt32(Console.ReadLine());

            while (k <= 0)
            {
                Console.WriteLine("Incorrect \'k\'. Try again.");
                k = Convert.ToInt32(Console.ReadLine());
            }


            
            double[,] matrixA = GenerateRandomMatrix(rnd, n, m, -10, 20); //Генерим первую матрицу
            double[,] matrixB = GenerateRandomMatrix(rnd, n, m, -10, 20); //Генерим вторую матрицу
            double[,] matrixC = new double[n, m]; //Инициализируем матрицу, где будет храниться матрица А, умноженная на число
            double[,] matrixSum = new double[n, m]; //Инициализируем матрицу, где будет храниться сумма матриц A и B
            double[,] matrixMult = GenerateRandomMatrix(rnd, m, k, -10, 20); //Генерим матрицу, на которую будет умножена матрица А
            double[,] matrixMultResult = new double[n, k]; //Инициализируем матрицу, где будет храниться произведение A*B


            Console.WriteLine($"Matrix A: ");
            PrintMatrix(matrixA);
            Console.WriteLine($"Matrix B: ");
            PrintMatrix(matrixB);


            Console.WriteLine("Enter \'lambda\' - multiplier: ");

            lambda = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiplying matrix to an integer value lambda");
            Console.WriteLine($"{lambda} * A is:");
            matrixC = LambdaMatrixMultiplier(lambda, matrixA);
            PrintMatrix(matrixC);


            Console.WriteLine("A + B");

            PrintMatrix(MatrixMatrixSumm(matrixA, matrixB));

            Console.WriteLine("Multiplying A by X");
            Console.WriteLine("Matrix X: ");
            PrintMatrix(matrixMult);

            Console.WriteLine("A * X is:");
            matrixMultResult = MatrixMatrixMultiplier(matrixA, matrixMult);
            PrintMatrix(matrixMultResult);

           

            
            #endregion




            printString(getMinimalLengthWord("a aa AAA MMMM SSS dsds DS"));

            printString(getMaxLengthWord("assaas as a dddddddddddd sds"));

            isProgression(0, 2, 4, 6 , 7);

            isProgression(2, 4, 6, 8, 10);

            isProgression(-1, 1, 3, 5);

            isProgression(1, 2, 4, 8);

            Console.WriteLine(Ackermann(2,5));

            Console.WriteLine(Ackermann(1,2));

            Console.ReadKey();
        }
    }
}
