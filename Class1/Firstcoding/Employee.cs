using System;
using System.Collections.Generic;
using System.Text;

namespace Class1

{
   public class Employee
    {
        public int x;          //
        private int y;       //
        protected int z;   //
        internal int a;  // all of these are applicable for class, variables and method similarly .

        public void calculateSalary (int age)
        {
            cost();
            var t = x + y + z + a;
        }

        private void cost()
        {
            calculateSalary(35);
        }
    }

    public class specialEmployee : Employee
    {
        public void doSomethng()
        {
            var r = x + z + a; ///in function we get the variable that had declared in class.
        }
        
    }
}
