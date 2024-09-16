namespace Tyuiu.DmiterkoKD.Sprint0.Test5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        { return a + b; }
        public static int Subtration(int a, int b)
        { return a - b; }
        public static int Multiplicion(int a, int b)
        { return a * b; }
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = 0, на ноль делить нельзя");
                return -1;
            }
            return a / b;
        }
    }
}
