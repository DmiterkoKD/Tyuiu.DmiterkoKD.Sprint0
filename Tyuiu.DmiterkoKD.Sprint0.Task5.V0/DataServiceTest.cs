using Tyuiu.DmiterkoKD.Sprint0.Task5.V0.Lib;
namespace Tyuiu.DmiterkoKD.Sprint0.Task5.V0
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedAdditionValid()
        {

            Assert.That(DataService.Addition(5, 5), Is.EqualTo(10));
        }
        [Test]
        public void CheckedSubtrationValid()
        {

            Assert.That(DataService.Subtration(10, 5), Is.EqualTo(5));
        }
        [Test]
        public void CheckedMultiplicionValid()
        {

            Assert.That(DataService.Multiplicion(10, 5), Is.EqualTo(50));
        }
        [Test]
        public void CheckedDivisionValid()
        {

            Assert.That(DataService.Division(10, 5), Is.EqualTo(2));
        }
    }
}