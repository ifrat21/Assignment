using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {


            var cart = new shoppingcart();
            for (int i = 0; i < cart.items.Length; i++)
            {
                Console.WriteLine(cart.items[i].Getvat());
            }
        }


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
        public class product : item
        {
            public string name;
            public override double Getvat()  // as we define Getvat method in abstract class  and here we want to use the same method or Getvat thats why we have to write override keyword
            {
                return price * 15 / 100;
            }
        }

        public class giftcard : item
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
}



