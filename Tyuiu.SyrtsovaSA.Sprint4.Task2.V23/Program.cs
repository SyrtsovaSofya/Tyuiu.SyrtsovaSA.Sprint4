using Tyuiu.SyrtsovaSA.Sprint4.Task2.V23.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task2.V23; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                 *"); 
        Console.WriteLine("* Задание #2                                                           *"); 
        Console.WriteLine("* Вариант #23                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 15 элементов         *"); 
        Console.WriteLine("* заполненный случайными в диапазоне от 3 до 8 подсчитать сумму четных *"); 
        Console.WriteLine("* элементов массива.                                                   *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        Console.WriteLine("Введите количество элементов массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] numsArray = new int[len];
        for (int i = 0; i < len; i++)
            numsArray[i] = rnd.Next(3, 9);
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
