using Tyuiu.SyrtsovaSA.Sprint4.Task5.V28.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task5.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[,] mas = { { -1, -3, -1, -1, 3 },
                       { 2, 1, 2, -2, 2 },
                       { 0, -1, 1, -2, 0 },
                       { 1, 0, -1, 0, 3 },
                       { 3, 2, 2, 1, 1 } };
        int[,] res = ds.Calculate(mas);
        int[,] wait = { { 0, 0, 0, 0, 3 },
                       { 2, 1, 2, 0, 2 },
                       { 0, 0, 1, 0, 0 },
                       { 1, 0, 0, 0, 3 },
                       { 3, 2, 2, 1, 1 } };
        CollectionAssert.AreEqual(wait, res);
    } 
} 
