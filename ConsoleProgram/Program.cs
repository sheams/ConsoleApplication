using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{

    // Hello World Program
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Sheam");
            Console.ReadLine();
        }
    }*/




    // Building Blocks Program
    /* class Program
     {
         static void Main(string[] args)
         {
             var myString = "Hello I'm Sheam";
             Console.WriteLine(myString);
             int myFirstValue = 23;
             Double mySecondValue = 45.79;
             Double sum = myFirstValue + mySecondValue;
             Console.WriteLine(sum);
             Console.ReadLine();
         }
     }*/



    // Booleans Program
    /* class Program
     {
         static void Main(string[] args)
         {
             bool myFirstBoolean = 3 + 2 == 5;
             Console.WriteLine(myFirstBoolean);
             bool mySecondBoolean = 3 + 2 > 5;
             Console.WriteLine(mySecondBoolean);
             bool bothAreTrue = myFirstBoolean && mySecondBoolean;
             Console.WriteLine("bothAreTrue evaluates " + bothAreTrue);
             bool oneIsTrue = myFirstBoolean || mySecondBoolean;
             Console.WriteLine("oneIsTrue evaluates {0} becouse one expression is true", oneIsTrue);
             bool reverseMyFirstBoolean = !myFirstBoolean;
             Console.WriteLine("myFirstBoolean is {0} but reverseMyFirstBoolean is {1}", myFirstBoolean, reverseMyFirstBoolean);
             Console.ReadKey();
         }
     }*/




    // If Statements Program 
    /* class Program
     {
         static void Main(string[] args)
         {
             Console.Write("What is your age?");
             string ageAsString = Console.ReadLine();
             int age = int.Parse(ageAsString);

             if(age > 21)
             {
                 Console.WriteLine("You are an adult");
             }
             else
             {
                 Console.WriteLine("You are not adult");
                 Console.ReadKey();
             }
         }
     }*/




    // else if Statements Program 
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);

            if (age > 64)
            {
                Console.WriteLine("You are a senior citizen");
            }
            else if(age >= 21)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("Your are not adult");
                Console.ReadKey();
            }
        }
    }*/




    //  While Loops Program
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old are U");
            int age = int.Parse(Console.ReadLine());

            while(age > 0)
            {
                Console.Write("Happy Birthday ");
                age--; 
                //or
                // age = age - 1;
                //  age -= 1; 
            }
            Console.WriteLine("\nSheam!!");
            Console.ReadKey();
        }
    }*/




    // do While Loops Program
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old are U");
            int age = int.Parse(Console.ReadLine());

           do
            {
                Console.Write("Happy Birthday ");
                age--;
                //or
                // age = age - 1;
                // age -= 1; 
            }
            while (age > 0) ;
            Console.WriteLine("\nSheam!!");
            Console.ReadKey();
        }
    }*/




    //  For Loops Program-1
    /*class Program
    {
        static void Main(string[] args)
        {
            for (int age = 5; age > 0; age--) 
            {
                Console.Write("Happy Birthday ");
            }
            Console.WriteLine("\nSheam!!");
            Console.ReadKey();

        }
    }*/



    //  For Loops Program-2
    /*class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.Write("Happy Birthday! ");
            }
            Console.WriteLine("\nSheam!!");
            Console.ReadKey();

        }
    }*/



    //  For Loops Program-3
    class Program
    {
        static void Main(string[] args)
        {
            int age = 35;
            int newAge = ++age;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            newAge = ++age;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);
            Console.ReadKey();
        }
    }

}
