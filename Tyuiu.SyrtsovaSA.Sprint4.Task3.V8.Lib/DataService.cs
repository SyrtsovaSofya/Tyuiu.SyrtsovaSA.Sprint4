using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SyrtsovaSA.Sprint4.Task3.V8.Lib;

public class DataService : ISprint4Task3V8
{
    public int Calculate(int[,] array)
    {
        int min = 100;
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            if (array[3,i] < min)
                min = array[3,i];
        }
        return min;
    }
}
