using System;


namespace Class1

{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //int 32 bit
            short a; //16 bit
            long y; //64 bit
            string z; //text holder class= reference type
            char b; //single letter
            DateTime f; //time 
            float c; //decimal
            double e; //biger range of decimal point
            uint g; //unsigned int
            bool h; // true or false
            decimal i; //accurate calculation for larger number


            int p, q;
            p = 5;
            q = p;
            q = 6;
            Console.WriteLine("P: {0}  ,  Q: {1} ", p, q);

            student s1 = new student();
            s1.name = "ifrat";
            s1.age = 25;

            student s2 = new student();
            s2  = s1;
            s2.name = "Juthi";
            s2.age = 24;
            //s2 = s1;
            student s3 = new student();
            s3 = s2;
            s3.name = "kowshika";
            s3.age = 23;
            //s3 = s2;
            Console.WriteLine("Student 1 name: {0} , Student 1 age : {1}", s1.name, s1.age);
            Console.WriteLine("Student 2 name: {0} , Student 2 age : {1}", s2.name, s2.age);
            Console.WriteLine("Student 3 name: {0} , Student 3 age : {1}", s3.name, s3.age);

            point point = new point();
            point.x = 10;
            point.y = 20;

            point point1 = new point();
            point1 = point;
            point1.x = 3;
            point1.y = 19;


            Console.WriteLine("X : {0} ,  Y: {1}", point.x, point.y);
            Console.WriteLine("X : {0} ,  Y: {1}", point1.x, point1.y);

            Employee em = new Employee();
            em.a = 10;
            em.x = 20;
        }
    }

    struct point //value type
    {
         public int x;
     public   int y;
    }

    class student //reference type
    {
       public string name;
      public  int age;
    }
}
