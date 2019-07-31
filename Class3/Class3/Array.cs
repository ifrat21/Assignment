using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double[] ages = new double[n];
            //ages = new double[30]; // this is also valid because we can re-assign the value in array

            for(int i=0;i<ages.Length;i++)
            {
                ages[i] = int.Parse(Console.ReadLine());
            }


        }
    }


  

   
}
