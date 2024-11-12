using Tyuiu.SyrtsovaSA.Sprint4.Task6.V3.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task6.V3; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Сырцова С.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #4                                                            *"); 
        Console.WriteLine("* Тема: Класс Array                                                    *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #3                                                           *"); 
        Console.WriteLine("* Выполнила: Сырцова Софья Алексеевна | ИИПб-24-1                      *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Дан строковый массив данных [Январь, Февраль, Март, Апрель, *"); 
        Console.WriteLine("* Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь].        *"); 
        Console.WriteLine("* Используя класс Array подсчитайте количество элементов,              *"); 
        Console.WriteLine("* длина которых меньше 6.                                              *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************");
        string[] months = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];
        Console.WriteLine("Массив: ");
        foreach (string month in months)
            Console.WriteLine(month);
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine($"Количество элементов, длина которых меньше 6 = {ds.Calculate(months)}."); 
    } 
} 
