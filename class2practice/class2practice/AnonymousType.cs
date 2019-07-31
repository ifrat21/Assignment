using System;

namespace class2practice
{
    class Program
    {
        static void Main(string[] args)
        {

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

        }
    }
}


