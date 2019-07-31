using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
           var missile = new Missile();
           // missile.damagepower = 100;   //we can comment this as if we have used costructor in missile class 
           missile.fire();
           var gun = new Machinegun();
           gun.fire();
           */

            var cart = new shoppingcart();
            for(int i=0; i<cart.items.Length;i++)
            {
                Console.WriteLine(cart.items[i].Getvat());
            }

            /*   int x; //explicit variable 
               double y; //explicite variable

               var z = 5; //Implicit variable ( we should use var )
               var a = 5.6;//Implicite variable bydefault double 
               var e = 4.7f;// float   
               var u = 3.7m; 
               var b = true; //Implicit variable
               var c = DateTime.Now; // it shows current date along with time ( implicit variable)
               //Console.WriteLine("Hello World!");

            var q= x>y ? x:y // trinary operator, conditional check

            string s= "hello";
            string ss= s?? "Empty"; // part of trinary operator

            var t= x==null ? "empty" : t; //trinary operator, specialy aaplicable for null checking

   // anonymious type : use to create an object . we can not make a copy of it. it has seperate name with same or different values.
               var person = new
               {
                   firstName = "Ifrat",
                   lastName = "Jahan",
                   Age = 25
               };
               var person2 = new
               {
                   firstName = "Juthi",
                   lastName = "sarker"
               };

               Console.WriteLine(person.Age);
               Console.WriteLine(person2.firstName);
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
               return new Car;
           }


       }

       class Car
       {
           public int fuel;
       }
       */
        }
    }

    /*  // Interface, abstract class , normal class

      public interface IWeapon
      {
          void fire();  // everything will be customized
      }

      public abstract class Weapon   
      {
          protected int damagepower; //similar property

          public abstract void fire(); // non-similar
      }

      public class Missile: Weapon
      {
         // private int damagepower;

          public Missile() //constructor  same name as class, we use it to set values. in the main we should not define any values as we have used constructor
          {
              damagepower = 100;
          }

          public override void fire()
          {
              Console.WriteLine("Missile was fired by damage amount : {0}", damagepower);
          }
      }

      public class Machinegun:Weapon
      {
          //private int damagepower;

          public Machinegun() //constructor  same name as class, we use it to set values. in the main we should not define any values as we have used constructor
          {
              damagepower = 200;
          }

          public override void fire()
          {
              Console.WriteLine("Gun was fired by damage amount : {0}", damagepower);
          }
          */

        //FUNCTIONALITY
        // can buy product 
        //can buy giftcard
        //can add product and giftcard in the shoppingcart
        //i have three kinds of products: electronics, books, stationary 


        public interface IItem
    {
        double Getvat(); //as we can customize it thats why Getvat() method is here,
        double calculateDollarprice();
    }
        public abstract class item
    {
        public double price;  // common for product and giftcard class
        public string Imageurl;// same

        public abstract double Getvat(); // we can not define it properly thats why abstract or we can customize it 

        public double calculateDollarPrice() //uses both for product & giftcard class or common
        {
            return price / 80;
        }

    }
    public class product:item
    {
        public string name;
       public override double Getvat()  // as we define Getvat method in abstract class  and here we want to use the same method or Getvat thats why we have to write override keyword
        {
            return price *15 / 100;
        }
    }

    public class giftcard:item
    {
       
        public string Receiveremailaddress;

        public override double Getvat()
        {
            return 0;
        }

    }

    public class shoppingcart
        {
        public item[] items;

        }

    }



