using Tyuiu.SyrtsovaSA.Sprint4.Task1.V23.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint4.Task1.V23;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #4                                                            *");
        Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                        *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #23                                                          *");
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 17 элементов         *");
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 4 до 9 подсчитать *");
        Console.WriteLine("* сумму четных элементов массива.                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9   *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Введите значение {i} элемента массива:");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        foreach (int num in numsArray)
            Console.WriteLine(num + "\t");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Сумма четных чисел массива = {ds.Calculate(numsArray)}");
        Console.ReadKey();
    }
}
