using Tyuiu.SyrtsovaSA.Sprint4.Task6.V3.Lib; 
 
namespace Tyuiu.SyrtsovaSA.Sprint4.Task6.V3.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()
    {
        DataService ds = new DataService();
        string[] months = ["������", "�������", "����", "������", "���", "����", "����", "������", "��������", "�������", "������", "�������"];
        int res = ds.Calculate(months);
        Assert.AreEqual(4, res);
    } 
} 
