using System;

namespace class2practice_restpart_
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            switch(x)
            {
                case 1:
                    Console.WriteLine("X is 1");
                    break;
                case 2:
                    Console.WriteLine("X is 2");
                    break;
                default:
                    Console.WriteLine(" Not found");
                    break;
            }

            string name = "Ifratjahan";
            switch(name)
            {
                case "Ifratjahan":
                    Console.WriteLine("found");
                    break;
                case "juthisarker":
                    Console.WriteLine("not found");
                    break;
                default:
                    Console.WriteLine("Nothing is matched");
                    break;
                     
            }

 /*
            int a = 5;
            int b = 0;

            while (a>b)
            {
                a++;
            }

            do
            {
                Console.WriteLine("hello");
            }

            while (b < 10);


            for (int x=0;x<=10;x++)
            {

            if(x==2)
            {
            continue;

            }

            if(x==8)
            {
            break;
            }
            */

            string[] names = new string[10];
            names[0] = "nishu";
            names[1] = "jahan";

            foreach(var na in names)  //use for collection, list and array
            {
                Console.WriteLine(na);
            }




     
        }
    }
}
