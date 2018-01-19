using System;

namespace ProjectEuler3
{
    internal static class Program
    {
        private static bool NumOfPrime(int num)//이게 왜 static?
        {
            for (var i = 1; i < num/2; i++)//절반 까지만 하면 되는건가?
            {
                if (num % (i+1) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Main(string[] args)
        {
            const long num = 600851475143;
            for (var i = 1; i < Math.Sqrt(num); i++)
            {
                if (num % (i + 1) != 0) continue;
                if (NumOfPrime(i + 1))
                {
                    Console.WriteLine(i + 1);
                }

            }
        }
    }
}