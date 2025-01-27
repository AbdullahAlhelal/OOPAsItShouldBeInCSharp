using System;
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
}
class clsCalculator
{
    private float _Result = 0;
    private float _LastNumber = 0;
    private string _LastOperation = "Clear";

    private bool _IsZero(float Number)
    {
        return (Number == 0);
    }

    public void Add(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Adding";
        _Result += Number;
    }

    public void Subtract(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Subtracting";

        _Result -= Number;
    }

    public bool Divide(float Number)
    {

        bool Succeeded = true;
        _LastOperation = "Dividing";

        if ( _IsZero(Number) )
        {
            _LastNumber = Number;
            _Result /= 1;
            Succeeded = false;
        }
        else
        {
            _LastNumber = Number;
            _Result /= Number;
        }

        return Succeeded;
    }

    public void Multiply(float Number)
    {
        _LastNumber = Number;
        _LastOperation = "Multiplying";
        _Result *= Number;
    }

    public float GetFinalResults()
    {
        return _Result;
    }

    public void Clear()
    {
        _LastNumber = 0;
        _LastOperation = "Clear";
        _Result = 0;
    }

    public void PrintResult()
    {
        Console.WriteLine("Result After {0} {1} is : {2}" , _LastOperation , _LastNumber , _Result);
    }
}
internal class Program
{
    static void Main(string[] args)
    {

        clsCalculator Calculator1 = new clsCalculator();


        Calculator1.Clear();

        Calculator1.Add(10);
        Calculator1.PrintResult();

        Calculator1.Add(100);
        Calculator1.PrintResult();

        Calculator1.Subtract(20);
        Calculator1.PrintResult();

        Calculator1.Divide(0);
        Calculator1.PrintResult();

        Calculator1.Divide(2);
        Calculator1.PrintResult();

        Calculator1.Multiply(3);
        Calculator1.PrintResult();

        Calculator1.Clear();
        Calculator1.PrintResult();

        Console.ReadLine();

    }
}

