﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{

//    class clsPerson 
//    {

//        public string FirstName;
//        public string LastName;
//        public string FullName() 
//        {
//            return FirstName + " "+ LastName;
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Create object from class
//            clsPerson Person1 = new clsPerson();


//            Console.WriteLine("Accessing Object 1 (Person1):");
//            Person1.FirstName = "Mohammed";
//            Person1.LastName = "Abu-Hadhoud";
//            Console.WriteLine(Person1.FullName());


//            //Create another object from class
//            clsPerson Person2 = new clsPerson();
//            Console.WriteLine("\nAccessing Object 2 (Person2):");
//            Person2.FirstName = "Ali";
//            Person2.LastName = "Maher";
//            Console.WriteLine(Person2.FullName());

//            Console.ReadKey();
//        }
//    }
//}

namespace ConsoleApp1
{

    class clsA
    {
        public int x1;
        //x2 is shared for all object because it's on the class level
        public static int x2;


        public int Method1()
        {
            //not static methods can always access the static members
            return x1 + x2;
        }

        public static int Method2()
        {
            //static methods cannot access non-static memebers because there is no object
            //static methods are called at the class level.
            //return clsA.x1 + x2;
            return x2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of Employee class.
            clsA objA1 = new clsA();
            clsA objA2 = new clsA();


            objA1.x1 = 7;
            objA2.x1 = 10;
            //x2 is shared for all object because it's on the class level, you can access it 
            //using the class name.
            clsA.x2 = 100;


            Console.WriteLine("objA1.x1:={0}", objA1.x1);
            Console.WriteLine("objA2.x1:={0}", objA2.x1);
            Console.WriteLine("objA1.method1 results:={0}", objA1.Method1());
            Console.WriteLine("objA2.method1 results:={0}", objA2.Method1());


            //Method 2 cannot be accessed through object, only through the class itself.
            //  Console.WriteLine(objA1.Method2());
            Console.WriteLine("static method2 results:={0}", clsA.Method2());

            Console.WriteLine("static x2:={0}", clsA.x2);
            Console.ReadLine();
        }
    }

}
