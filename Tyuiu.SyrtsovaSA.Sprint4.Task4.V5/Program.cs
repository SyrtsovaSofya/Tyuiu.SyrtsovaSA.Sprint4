using Tyuiu.SyrtsovaSA.Sprint4.Task4.V5.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task4.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Двумерные массивы. Ввод с клавиатуры                           *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #5                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5 элементов,        *"); 
        Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 3 до 9.           *"); 
        Console.WriteLine("* Найдите сумму четных элементов массива.                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        int[,] array = new int[5, 5];
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;
        Console.WriteLine("Введите элементы двумерного массива 5 на 5: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                array[i, j] = Convert.ToInt32(Console.ReadLine());
        };
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write($"{array[i, j]}  ");
            Console.WriteLine();
        };
        Console.WriteLine();
        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");
        Console.WriteLine($"Сумма четных элементов массива = {ds.Calculate(array)}");
        Console.ReadKey();
    } 
} 
