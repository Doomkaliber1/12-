using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    { 
        
            class GFG
        {
            static void sort(int[] arr)
            {
                int n = arr.Length;


                // Цикъл for 
                for (int i = 0; i < n - 1; i++)
                {
                    
                    int min_idx = i;
                    for (int j = i + 1; j < n; j++)
                        if (arr[j] < arr[min_idx])
                            min_idx = j;


                    // Намира минималната стойност
                    //int temp = arr[min_idx];
                    arr[min_idx] = arr[i];
                    //arr[i] = temp;
                }
            }


            
            static void printArray(int[] arr)
            {
                // Създава се дължина на масива
                int n = arr.Length;
                for (int i = 0; i < n; ++i)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }


            // Driver code
            public static void Main()
            {
                var watch = new System.Diagnostics.Stopwatch();
                // Създава се масив с 10000 точки на достъп
                int[] arr = new int[10000];
                // Генерираните стойности са от 0 до 2000
                int Min = 0;
                int Max = 2000;

                int[] test2 = new int[5];
                // Създава случайни стойности
                Random randNum = new Random();
          

                for (int i = 0; i < 1000; i++)
                {
                   arr[i] = randNum.Next(Min, Max);
                }
                // Стартира таймер, докато сортира стойностите
                watch.Start();
                sort(arr);
                // Спира таймера
                watch.Stop();
                Console.WriteLine("Sorted array");
                printArray(arr);
                {
                    Console.Write(arr);
                }
                // Извежда на екрана времето от таймера
                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            }


        }
    }
}

