using System;

namespace MethodExercise2
{
    internal class Program
    {
        static void Main(string[] args)
          {
            int total1 = Sum(3, 100, 3, 5);
            int difference1 = Subt(5, 2, 1);
            int product1 = Multiply(2, 4, 2, 2);
            int quotient1 = Div(16, 2, 2);

            
            Console.WriteLine(total1);
            Console.WriteLine(difference1);
            Console.WriteLine(product1);
            Console.WriteLine(quotient1);

        }

        static public int Sum(params int[] sums1)
        {
           int total = 0;
            foreach (int i in sums1)
            {
                total += i;
            }
            return total;
        }
        static public int Subt(params int[] subs1)
        {
            int difference = subs1[0] + subs1[0];
            foreach( int num in subs1)
            {
                difference -= num;
            }
            return difference;
        }
        static public int Multiply(params int[] mults1)
        {
            int product = 1;
            for(int i = 0; i < mults1.Length; i++)
            { 
                product *= mults1[i];
            }
            return product;
        }
        static public int Div(params int[] divs1)
        {
            int quotient = divs1[0] * divs1[0];
            foreach(int num in divs1)
            {
                quotient /= num;
            }
            return quotient;
        }

        

    }
}
