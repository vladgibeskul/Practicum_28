using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 14;
            int[] myArray = Input(arraySize);
            int evenCount = Value(myArray);
            Console.WriteLine($"Количество четных элементов в массиве: {evenCount}");
            Console.ReadKey();
        }
        public static int[] Input(int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Введите {size} элементов массива:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    array[i] = element;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                    i--;
                }
            }
            return array;
        } 
        
        public static int Value(int[] array)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
