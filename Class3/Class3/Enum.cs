using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(weekDays.sunday);

            var user = new User();
            if(user.Status==registrationStatus.Active && user.Type==userType.Admin)
            {
                Console.WriteLine("Successfully Login");
            }

        }
    }


   /*enum weekDays // for set options 
        {
           monday,  //0 by default or we can set anything
           tuesday,  //1
           wednesday, //2
           thursday,  
           friday,
           saturday,
           sunday
        }*/

    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public registrationStatus Status { get; set; } // here , enum is used as a data type
        public userType Type { get; set; }             
    }

   public enum registrationStatus
    {
        Inactive,
        Blocked,
        Active
    }

   public enum userType
    {
        Member,
        Support,
        Admin,
        SuperAdmin
    }

   
}
