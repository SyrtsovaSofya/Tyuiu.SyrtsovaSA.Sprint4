using Tyuiu.SyrtsovaSA.Sprint4.Task2.V23.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task2.V23.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[] numsArray = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
        int res = ds.Calculate(numsArray);
        Assert.AreEqual(36, res);
    } 
} 
