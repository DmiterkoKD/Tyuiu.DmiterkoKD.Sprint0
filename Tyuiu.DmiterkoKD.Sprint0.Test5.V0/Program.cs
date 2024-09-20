using Tyuiu.DmiterkoKD.Sprint0.Test5.V0.Lib;
namespace Tyuiu.DmiterkoKD.Sprint0.Test5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A+B =" + DataService.Addition(3, 5));
            Console.WriteLine("A-B = " + DataService.Subtration(15, 5));
            Console.WriteLine("A*B = " + DataService.Multiplicion(10, 10));
            Console.WriteLine("A/B = " + DataService.Division(15, 3));
        }
    }
}
