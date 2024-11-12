using Tyuiu.SyrtsovaSA.Sprint4.Task7.V9.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task7.V9.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        string value = "864299753";
        int res = ds.Calculate(3, 3, value);
        Assert.AreEqual(4, res);
   } 
} 
