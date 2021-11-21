using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            int oddNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 51);
            }
            Console.WriteLine("Программа определяет количество нечетных положительных элементов, стоящих на четных местах");
            Console.WriteLine();
            Console.WriteLine("Одномерный массив из 20 случайных чисел в диапазоне [-50,50]:");

            Console.WriteLine(" ___________ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ____ ");
            Console.Write("|   Число   |");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0, 4}|", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("|___________|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|");
            Console.WriteLine("|  Позиция  |  01|  02|  03|  04|  05|  06|  07|  08|  09|  10|  11|  12|  13|  14|  15|  16|  17|  18|  19|  20|");
            Console.WriteLine("|___________|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|");
            Console.WriteLine("|  Чет.поз. |    |  + |    |  + |    |  + |    |  + |    |  + |    |  + |    |  + |    |  + |    |  + |    |  + |");
            Console.WriteLine("|___________|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|");
            Console.Write("|  Неч.числ.|");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write("    |", array[i]);
                }
                else
                {
                    Console.Write("  + |", array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("|___________|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|");
            Console.Write("|  Пол.числ.|");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.Write("    |", array[i]);
                }
                else
                {
                    Console.Write("  + |", array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("|___________|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|____|");
            for (int i = 1; i < 20; i+=2)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                    oddNumbers++;
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах в данном массиве: {0}", oddNumbers);
            Console.ReadLine();
        }
    }
}
