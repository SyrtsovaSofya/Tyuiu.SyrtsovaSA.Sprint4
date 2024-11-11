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
        Console.WriteLine("* Тема:                                                                *");
        Console.WriteLine("* Задание #1                                                           *");
        Console.WriteLine("* Вариант #23                                                          *");
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                                                          *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("*                                                                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
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
