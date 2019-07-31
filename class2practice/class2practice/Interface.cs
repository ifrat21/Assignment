using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {



            var missile = new Missile();
            // missile.damagepower = 100;   //we can comment this as if we have used costructor in missile class 
            missile.fire();
            var gun = new Machinegun();
            gun.fire();

          /*  Weapon[] weapons = new Weapon[2];
            weapons[1] = new Missile();
            weapons[2] = new Machinegun();

            for(int i=0;i<2;i++)
            {
                weapons[i].fire();
            }*/
        }
    }

    // Interface, abstract class , normal class

    public interface IWeapon
    {
        void fire();  // everything will be customized
    }

    public abstract class Weapon
    {
        protected int damagepower; //similar property

        public abstract void fire(); // non-similar
    }

    public class Missile : Weapon
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

    public class Machinegun : Weapon
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


    }
}



