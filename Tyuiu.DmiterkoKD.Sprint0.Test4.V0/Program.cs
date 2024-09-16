using Tyuiu.DmiterkoKD.Sprint0.Test4.V0.Lib;

namespace Tyuiu.DmiterkoKD.Sprint0.Test4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtration(27, 5));
            Console.WriteLine(DataService.Multiplicion(150, 5));
            Console.WriteLine(DataService.Division(50, 5));
            Console.ReadKey();
        }
    }
}
