using System;

namespace class2practice_restpart_
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 5;
            int b = 0;

            for (int x = 0, y = 5; x < 10 && y < 10; x++, y--)
            {
                if (x == 2)
                {
                    continue;
                }
                if (x == 10)
                {
                    break;
                }

            }

            /*   for (int i=0;i<5;i++)
               {
                   if(i==3)

                       continue;
                   Console.WriteLine(i)
               }*/
            while (a > b)
            {
                a++;
            }

            do
            {
                Console.WriteLine("hello");
            }

            while (b < 10);


            for (int x = 0; x <= 10; x++)
            {

                if (x == 2)
                {
                    continue;

                }

                if (x == 8)
                {
                    break;
                }


                string[] names = new string[10];
                names[0] = "nishu";
                names[1] = "jahan";

                foreach (var na in names)  //use for collection, array
                {
                    Console.WriteLine(na);
                }





            }
        }
    }
}
