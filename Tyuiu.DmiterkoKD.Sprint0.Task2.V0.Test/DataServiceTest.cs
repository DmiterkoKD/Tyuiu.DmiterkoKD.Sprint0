using Tyuiu.DmiterkoKD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DmiterkoKD.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckGetMessageValid()
        {
            var name = "Kira";
            var res = DataService.GetMessage(name);
            Assert.That(res, Is.EqualTo("Привет... , Кира"));
        }
    }
}