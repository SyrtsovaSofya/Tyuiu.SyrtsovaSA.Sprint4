using Tyuiu.SyrtsovaSA.Sprint4.Task7.V9.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task7.V9; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #9                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дана строка из одноразрядных цифр 864299753. Преобразуйте   *"); 
        Console.WriteLine("* ее в матрицу 3 на 3 и подсчитайте количество четных чисел.           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");        
        string value = "864299753";
        int n = 3;
        int m = 3;
        int[,] matrix = new int[3, 3];
        int index = 0;
        Console.WriteLine("Массив:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Количество четных чисел = {ds.Calculate(n, m, value)}"); 
    } 
} 
