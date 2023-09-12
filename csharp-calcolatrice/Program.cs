using csharp_calcolatrice.Helpers;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SUMM
            Console.WriteLine(MathHelper.IntSumm(4, 6));
            Console.WriteLine(MathHelper.DoubleSumm(4.832656446548, 4564654656.5));

            //DIFFERENCE
            Console.WriteLine(MathHelper.IntDiff(6,8));
            Console.WriteLine(MathHelper.DoubleDiff(6.1567,8.9665));

            //MULTIPLICATION
            Console.WriteLine(MathHelper.IntMultiplier(3,8));
            Console.WriteLine(MathHelper.DoubleMultiplier(3.65,4.21));

            //ABSOLUTE
            Console.WriteLine(MathHelper.IntAbsolute(-6));
            Console.WriteLine(MathHelper.DoubleAbsolute(-42.12));

            //MINOR NUMBER
            Console.WriteLine(MathHelper.IntMinor(12,6));
            Console.WriteLine(MathHelper.DoubleMinor(10.22,10.65));

            //MAX NUMBER
            Console.WriteLine(MathHelper.IntMax(12, 6));
            Console.WriteLine(MathHelper.DoubleMax(10.22, 10.65));

        }
    }
}