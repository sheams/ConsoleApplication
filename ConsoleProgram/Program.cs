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
    /*class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (;; )
            {
                Console.Write("Happy Birthday! ");
                ++i;
                if(i > 10)
                {
                    break;
                }
            }
            //int age = 35;
            //int newAge = ++age;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            //newAge = ++age;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);
            //Console.ReadKey();
        }
    }*/




    //  For Loops Program-4
    /*class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (;;)
            {
                ++i;
                if (i == 5)
                {
                    continue;
                }
                Console.Write("Happy Birthday! {0} ", i);
                Console.ReadKey();
                if(i > 10)
                {
                    break;
                }
            }
        }
    }*/





    //  For Loops Program-5
    /*class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2000; i++)
            {
                if (i % 100 == 0)
                {
                    Console.Write("Happy Birthday! {0} ", i);

                }
            }
            Console.ReadKey();
        }
    }*/




    // Switch Statements program
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number betwen 1 and 5 :");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 5:
                    Console.WriteLine("Your picked the biggest legal value");
                    break;
                case 4:
                    Console.WriteLine("You Chose 4");
                    break;
                case 3:
                    Console.WriteLine("You Chose 3");
                    break;
                case 2:
                    Console.WriteLine("You Chose 2");
                    break;
                case 1:
                    Console.WriteLine("Your picked the lowest legal value");
                    break;
                default:
                    Console.WriteLine("Not a leger Entry. please try again");
                    break;
            }
            Console.ReadKey();
        }
    }*/




    // Enumerations Program
    /* class Program
     {
         enum Color
         {
             Red,
             Orange,
             Green,
             Blue,
             Indigo,
             Violet
         }
         static void Main(string[] args)
         {
             Color favorite = Color.Green;
             switch(favorite)
             {
                 case Color.Red:
                     Console.WriteLine("You chose Red");
                     break;

                 case Color.Violet:
                     Console.WriteLine("You chose Violet");
                     break;

                 case Color.Orange:
                     Console.WriteLine("You chose Orange");
                     break;

                 case Color.Indigo:
                     Console.WriteLine("You chose Indigo");
                     break;

                 case Color.Green:
                     Console.WriteLine("You chose Green");
                     break;

                 case Color.Blue:
                     Console.WriteLine("You chose Blue");
                     break;
                 default:
                     Console.WriteLine("U didn't chose a color");
                     break;
             }
             Console.ReadKey();
         }
     }*/




    //  Properties and Fields Program
    /* class Program
     {
         class Employee
         {
             private int age;
             public int Age
             {
                 get { return age; }
                 set { age = value; }
             }
         }
         static void Main(string[] args)
         {
             Employee Dave = new Employee();
             Dave.Age = 35;
             Console.WriteLine("Dave's age is {0}", Dave.Age);
             Console.ReadKey();
         }
     }*/





    // Constructors and Initialization Program-1
    /*class Program
    {
        class Employee
        {
            public int Age { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
            public DateTime startingDate { get; set; }


            public void Bonus(double bonousPrecent)
            {
                salary += salary * bonousPrecent;
            }
        }
        static void Main(string[] args)
        {
            Employee Dave = new Employee()
            {
                Age = 25,
                name = "David",
                salary = 50000.00,
                startingDate = new DateTime(2015,12,4 ),
            };
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}", Dave.Age, Dave.startingDate, Dave.salary);
            Dave.Bonus(0.05);
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}", Dave.Age, Dave.startingDate, Dave.salary);
            Console.ReadKey();
        }
    }*/





    // Constructors and Initialization Program-2
    class Program
    {
        class Employee
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
            public DateTime StartingDate { get; set; }


            public void Bonus(double bonousPrecent)
            {
                Salary += Salary * bonousPrecent;
            }

            public Employee(int age, string name, double salary, DateTime startingDate)
            {
                Age = age;
                Name = name;
                Salary = salary;
                StartingDate = startingDate;

            }

            public Employee()
            {

            }
        }
        static void Main(string[] args)
        {
            Employee Dave = new Employee()
            {
                Age = 25,
                Name = "David",
                Salary = 50000.00,
                StartingDate = new DateTime(2015, 12, 4),
            };
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}", Dave.Age, Dave.StartingDate, Dave.Salary);
            Dave.Bonus(0.05);
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}", Dave.Age, Dave.StartingDate, Dave.Salary);
            Employee Mary = new Employee(25, "Mary", 60000, new DateTime(2015, 12, 4));
            Console.WriteLine("\n\nMary's age is {0} she started on {1} and amkes {2}", Mary.Age, Mary.StartingDate, Mary.Salary);
            Console.ReadKey();
        }
    }
}
