using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task6.V3.Lib;

public class DataService : ISprint4Task6V3
{
    public int Calculate(string[] array)
    {
        return Array.FindAll(array, s => s.Length < 6).Length;
    }
} 
