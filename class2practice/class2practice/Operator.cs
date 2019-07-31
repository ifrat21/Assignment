using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = x + y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = x << y; //bitwise operator for bit shifting
            z = x >> y;

            if(x>y)
            {

            }

            if(x<y)
            {

            }

            if(x<=y)
            {

            }
            if(x>=y)
            {

            }

            if(x==y)
            {

            }

            if (x!=y)
            {

            }
            z = x & y; //bitwise and 
            z = x | y; //bitwise or
            z = x ^ y;  //for 00 or 11 it will give 1 

            bool a= true; //logical 
            bool b = false;
            bool c = a && b;
            c = a || b;
            c =!b;

            string s = "hello";
            string ss = s ?? "Empty"; // null check

            z = x > y ? x : y; //trinary operator

            x++;
            x--;
            ++x;
            --x;
            z = x++ * 5; //25, x=6 
            z = ++x * 5; //30, x=6

            x += 5;
            x -= 5;
            x *= 5;
            x /= 5;
        }
    }
}


