using Tyuiu.DmiterkoKD.Sprint0.Test3.V0.Lib;
namespace Tyuiu.DmiterkoKD.Sprint0.Test3.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckedValid()
        {
            Assert.That(DataService.Sum(5,5), Is.EqualTo(10));
        }

        
    }
}