using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {

   // dynamic type: here we can assign any value , always get the updated value in cw . we can make many copy with a same keyword dynamic something variable...and assign different values.
               dynamic something = "nishu";
               something = 10;
               something = true;
               something = 3.3;
               something = new
               {
                   name = "mesbha",
                   age = 32
               };
               Console.WriteLine(something);

              //  use of var is very important because if we change any class name we should not change it in the variable section where we want to call the getcar function ..so using var is a good practice
              // Car c = new Car();
              // var d = new Car();

               Car c = GetCar();
               var d = GetCar();
           }

           public static Car GetCar()
           {
               return new Car();
           }


       }

       class Car
       {
           public int fuel;
       }
       
     
  }



