using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = BmiCalculator.GetBmi(80, 1.7);
            Console.WriteLine(c);
        }
    }
}
