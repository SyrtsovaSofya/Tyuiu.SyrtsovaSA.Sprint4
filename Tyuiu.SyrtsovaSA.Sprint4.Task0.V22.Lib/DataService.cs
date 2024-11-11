using tyuiu.cources.programming.interfaces.Sprint4; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task0.V22.Lib;

public class DataService : ISprint4Task0V22
{
    public int GetSumOddArrEl(int[] array)
    {
        int sum = 0;
        foreach (var num in array)
            if (num % 2 != 0)
                sum += num;
        return sum;
    }
} 
