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
                case "NamrataSaha":
                    Console.WriteLine("not found");
                    break;
                default:
                    Console.WriteLine("Nothing is matched");
                    break;
                     
            }





     
        }
    }
}
