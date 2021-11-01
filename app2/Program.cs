using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLIENT 1 
            Console.WriteLine("Please enter the height and width of the array");
            int height1 = Convert.ToInt32(Console.ReadLine());
            int width1 = Convert.ToInt32(Console.ReadLine());
            Print(GetArr(height1, width1));
            //CLIENT 2
            Console.WriteLine("Please enter the height and width of your array");
            int height2 = Convert.ToInt32(Console.ReadLine());
            int width2 = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = GetArr(height2, width2);
            Print(arr2);
            Print(Console.ReadLine(), Max(arr2));
            Print(Console.ReadLine(), Min(arr2));
            //CLIENT 3
            Console.WriteLine("Please enter the height of your array");
            int height3 = Convert.ToInt32(Console.ReadLine());
            int[,] arr3 = GetArr(height3, height3);
            Print(arr3);
            Console.WriteLine();
            Print(Diagonal1(arr3));
            Console.WriteLine();
            Print(Diagonal2(arr3));
            Console.WriteLine();
            //CLIENT 4
            Console.WriteLine("Please enter the height and width of your array");
            int height4 = Convert.ToInt32(Console.ReadLine());
            int width4 = Convert.ToInt32(Console.ReadLine());
            int[,] arr4 = GetArr(height4, width4);
            Print(arr4);
            Print(Console.ReadLine(), Max(arr4));
            Print(Console.ReadLine(), Min(arr4));
            Print(MaxIndices(arr4));
            Console.WriteLine();
            Print(MinIndices(arr4));
            //etc...
        }

        /// <summary>
        /// Fills array of given size with random numbers
        /// </summary>
        /// <param name="height">Any Int32 value given by the client</param>
        /// <param name="width">Any Int32 value given by the client</param>
        /// <returns>2d array</returns>
        public static int[,] GetArr(int height, int width)
        {
            int[,] arr = new int[height, width];
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rnd.Next(100, 1000);
                }
            }
            return arr;
        }
        /// <summary>
        /// Finds and returns the maximum of the given array 
        /// </summary>
        /// <param name="arr">any given 2d array</param>
        /// <returns>Int32 value</returns>
        public static int Max(int[,] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        /// <summary>
        /// Finds and returns minimum of the given array
        /// </summary>
        /// <param name="arr">any given 2d array</param>
        /// <returns>Int32</returns>
        public static int Min(int[,] arr)
        {
            int min = 1000;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the indices of the maximum value in the given array
        /// </summary>
        /// <param name="arr">any given array</param>
        /// <param name="max">maximum of the given array</param>
        /// <returns>array of two Int32 values</returns>
        public static int[] MaxIndices(int[,] arr)
        {
            int[] indices = new int[2];
            int iMax = 0;
            int jMax = 0;
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        iMax = i;
                        jMax = j;
                    }

                }
            }
            indices[0] = jMax;
            indices[1] = iMax;
            return indices;
        }
        /// <summary>
        /// Finds the indices of the minimum value in the given array
        /// </summary>
        /// <param name="arr">any given array</param>
        /// <param name="min">maximum of the array</param>
        /// <returns>array of two Int32 values</returns>
        public static int[] MinIndices(int[,] arr)
        {
            int[] indices = new int[2];
            int min = arr[0, 0];
            int iMin = 0;
            int jMin = 0;

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        iMin = i;
                        jMin = j;
                    }

                }
            }
            indices[0] = jMin;
            indices[1] = iMin;
            return indices;
        }

        /// <summary>
        /// Gets the primary diagonal of the given array
        /// </summary>
        /// <param name="arr">any given 2d array</param>
        /// <returns>array of Int32 values</returns>
        public static int[] Diagonal1(int[,] arr)
        {
            int[] diagonal = new int[arr.GetLength(0)];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(100, 1000);
                    diagonal[i] = arr[i, i];
                }

            }
            return diagonal;
        }
        /// <summary>
        /// Gets the secondary diagonal of the given array
        /// </summary>
        /// <param name="arr">any given 2d array</param>
        /// <returns></returns>
        public static int[] Diagonal2(int[,] arr)
        {
            int[] diagonal = new int[arr.GetLength(0)];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(100, 1000);
                    diagonal[i] = arr[i, arr.GetLength(0) - i - 1];
                }

            }
            return diagonal;
        }

        /// <summary>
        /// Finds the maximum of the given diagonal
        /// </summary>
        /// <param name="diagonal">Int32 array</param>
        /// <returns>Int32 value</returns>
        public static int DiagonalMax(int[] diagonal)
        {
            int max = diagonal[0];
            for (int i = 0; i < diagonal.Length; i++)
            {
                if (max < diagonal[i])
                {
                    max = diagonal[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the minimum of the given diagonal
        /// </summary>
        /// <param name="diagonal">Int32 array</param>
        /// <returns>Int32 value</returns>
        public static int DiagonalMin(int[] diagonal)
        {
            int min = diagonal[0];
            for (int i = 1; i < diagonal.Length; i++)
            {
                if (diagonal[i] < min)
                {
                    min = diagonal[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Prints the 2d array
        /// </summary>
        /// <param name="arr">any given 2d array</param>
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Prints the elements of the diagonal of an array
        /// </summary>
        /// <param name="diagonal">Int32 array </param>
        public static void Print(int[] diagonal)
        {
            foreach (int i in diagonal)
            {
                Console.Write($"{i} ");
            }
        }
        /// <summary>
        /// Prints the text along with the value 
        /// </summary>
        /// <param name="text">any string input by the user</param>
        /// <param name="num">any int value</param>
        public static void Print(string text, int num)
        {
            Console.WriteLine($"{text} {num}");
        }

        public static void Swap(int[,] arr, int[] indices1, int[] indices2)
        {
            arr[indices1[0], indices1[1]] = arr[indices2[0], indices2[1]];
            arr[indices2[0], indices2[1]] = arr[indices1[0], indices1[1]];
        }
        public static void Swap(int[] arr, int index1, int index2)
        {
            arr[index1] = arr[index2];
            arr[index2] = arr[index1];
        }


    }
}