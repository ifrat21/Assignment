using System;

namespace Class3
{
    class Property
    {
        static void Main(string[] args)
        {
            var person = new person();
            person.name = "IfratJahan";
        }
    }

    class person
    {
     //public string name;  //variable
     //public int age;       // variable
     //public string name { get; set; }  //property



       /*                 private string name1;
                        public string getname()
                               {
                                    return name1;
                               }
                        public string setname(string n)   //normal form
                               {
                                    name1 = n;
                               } */



        private string name;
        public string setname(string n)
        {
              if (n != string.Empty)   //we can apply our own logic to make our variable private
            {
                name = n;
                hasNameChanged = true;
                

            }
        }
        public string getname()
        {
              if (name == null)
                return string.Empty;

            else
                return name;
            
        }

        public bool hasNameChanged;
    }
}
