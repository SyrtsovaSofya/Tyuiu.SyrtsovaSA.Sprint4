using Tyuiu.SyrtsovaSA.Sprint4.Task0.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task0.V22; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                          *"); 
        Console.WriteLine("* Задание #0                                                           *"); 
        Console.WriteLine("* Вариант #22                                                          *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан одномерный целочисленный массив на 10 элементов         *"); 
        Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9.           *"); 
        Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                         *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}                      *"); 
        Console.WriteLine("************************************************************************");
        int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
        Console.WriteLine("Исходный массив:");
        foreach (int num in numsArray)
            Console.Write(num + " ");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Сумма нечетных чисел массива = {ds.GetSumOddArrEl(numsArray)}"); 
        Console.ReadKey();
    } 
} 
