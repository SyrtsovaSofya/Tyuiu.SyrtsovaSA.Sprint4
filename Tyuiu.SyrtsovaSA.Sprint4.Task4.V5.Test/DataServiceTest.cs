using Tyuiu.SyrtsovaSA.Sprint4.Task4.V5.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task4.V5.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[,] mas = { { 6, 3, 6, 6, 7 },
                       { 9, 8, 9, 7, 9 },
                       { 5, 6, 8, 7, 5 },
                       { 8, 5, 6, 5, 3 },
                       { 3, 9, 9, 8, 8 } };
        int res = ds.Calculate(mas);
        Assert.AreEqual(70, res);
    } 
} 
