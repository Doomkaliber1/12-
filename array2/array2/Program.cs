using System;

namespace array2
{
    class Program
    {

           static void merge(int[] a, int from, int mid, int to)
        {
            int n = to - from + 1; // Size of the range to be merged 
                                   // Merge both halves into a temporary array b 
                                   // We allocate the array dynamically since its size is only
                                   // known at run time--see Section 7.4
           int[] b = new int[n];

            int i1 = from;
            // Следващият елемент, който трябва да се вземе предвид през първата половина
            int i2 = mid + 1;
            // Следващият елемент, който трябва да се вземе предвид през втората половина
            int j = 0; // Next open position in b 

            // As long as neither i1 nor i2 is past the end, move the smaller
            // element into b

            while (i1 <= mid && i2 <= to)
            {
                if (a[i1] < a[i2])
                {
                    b[j] = a[i1];
                    i1++;
                }
                else
                {
                    b[j] = a[i2];
                    i2++;
                }
                j++;
            }

            // Имайте предвид, че се изпълнява само един от двата цикъла while по -долу

            // Копирайте всички останали записи от първата половина
            while (i1 <= mid)
            {
                b[j] = a[i1];
                i1++;
                j++;
            }
            // Копирайте всички останали записи от втората половина
            while (i2 <= to)
            {
                b[j] = a[i2];
                i2++;
                j++;
            }

            // Копирайте обратно от временния масив
            for (j = 0; j < n; j++)
            {
                a[from + j] = b[j];
            }

            // Временният масив вече не е необходим.
           // delete[] b;
        }

        /**  
           Сортира елементите в диапазон от масив.
           @param a the array with the elements to sort
           @param from start of the range to sort
           @param to end of the range to sort
*/
        static void merge_sort(int[] a, int from, int to)
        {
            if (from == to) { return; }
            int mid = (from + to) / 2;
            //Сортирайте първата и втората половина
            merge_sort(a, from, mid);
            merge_sort(a, mid + 1, to);
            merge(a, from, mid, to);
        }

        /** 
          
           Отпечатва всички елементи в масив
           @param a the array to print
           @param size the number of elements in a
*/
        static void print(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
        // Генерират се числа от 0 до 100
        // Дължината на масива е 100 
        // Генерират се случайни стойности и само 100 от тях ще влязат в масива
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 100;
            Random randNum = new Random();
            const int SIZE = 100;
            int[] values = new int[SIZE];
                
            for (int i = 0; i < SIZE; i++)
                // Стойностите се делят на 100
            {
                int value = randNum.Next(Min, Max) % 100;
                // Цикъл for
                int j;
                for ( j = 0; j < i; j++)
                {
                    if (values[j] == value)
                    {
                        i--; break;
                    }
                }
                if (j == i)
                    values[i] = value;

           }
            // Извежда стойностите
            print(values, SIZE);
            merge_sort(values, 0, SIZE - 1);
            print(values, SIZE);
        }




    }
}
