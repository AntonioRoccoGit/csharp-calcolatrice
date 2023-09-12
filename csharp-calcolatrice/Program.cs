using csharp_calcolatrice.Helpers;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 6;
            int numberInt2 = 4;

            double numberDouble = 4.832656446548;
            double numberDouble2 = 656.5;

            //SUMM
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("SOMMA");
            Console.WriteLine(MathHelper.NumberSumm<int>(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberSumm<double>(numberDouble, numberDouble2));
            Console.WriteLine("-----------------------------------------");


            //DIFFERENCE
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DIFFERENZA");
            Console.WriteLine(MathHelper.NumberDiff<int>(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberDiff(numberDouble, numberDouble2));
            Console.WriteLine("-----------------------------------------");


            //MULTIPLICATION
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("MOLTIPLICAZION");
            Console.WriteLine(MathHelper.NumberMultiplier<int>(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMultiplier<double>(numberDouble, numberDouble2));
            Console.WriteLine("-----------------------------------------");

            //ABSOLUTE
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("VALORE ASSOLUTO");
            Console.WriteLine(MathHelper.NumberAbsolute<int>(-24));
            Console.WriteLine(MathHelper.NumberAbsolute<double>(-22.451));
            Console.WriteLine("-----------------------------------------");



            //MINOR NUMBER

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("MINORE");
            Console.WriteLine(MathHelper.NumberMinor<int>(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMinor<double>(numberDouble, numberDouble2));

            //MAX NUMBER
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("MAGGIORE");
            Console.WriteLine(MathHelper.NumberMax<int>(numberInt, numberInt2));
            Console.WriteLine(MathHelper.NumberMax<double>(numberDouble, numberDouble2));
            Console.WriteLine("-----------------------------------------");





            Console.WriteLine(MathHelper.NumberPower(3, 2));
            Console.WriteLine(MathHelper.NumberPower(3, -2));

            Console.WriteLine(MathHelper.NumberPower(3, 0));

            Console.WriteLine(MathHelper.NumberPower(0, 4));
            Console.WriteLine(MathHelper.NumberPower(0, 0));

        }
    }
}