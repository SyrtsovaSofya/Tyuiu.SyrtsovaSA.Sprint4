using Tyuiu.SyrtsovaSA.Sprint4.Task0.V22.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task0.V22.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
        int res = ds.GetSumOddArrEl(numsArray);
        Assert.AreEqual(46, res);
   } 
} 
