using Tyuiu.SyrtsovaSA.Sprint4.Task5.V28.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint4.Task5.V28;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1";
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* Спринт #4                                                            *");
        Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                 *");
        Console.WriteLine("* Задание #5                                                           *");
        Console.WriteLine("* Вариант #28                                                          *");
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,        *");
        Console.WriteLine("* заполненный случайными значениями в диапазоне от -6 до 3. Заменить   *");
        Console.WriteLine("* отрицательные элементы на 0.                                         *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
        Console.WriteLine("************************************************************************");
        int[,] numsArray = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                numsArray[i, j] = rnd.Next(-6, 4);
        }
        Console.WriteLine("Массив: ");
        PrintMatrix(numsArray);
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        int[,] res = ds.Calculate(numsArray);
        PrintMatrix(res);
        Console.ReadKey();
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write($"{matrix[i, j]}  ");
            Console.WriteLine();
        };
    }
}
