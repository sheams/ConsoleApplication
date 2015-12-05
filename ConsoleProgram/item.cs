using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // for p1
    /*public class item
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }*/






    /*
    // for p2
    class item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }
    }


    class Software : item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("My ID is {0} and My ISBN is {1}", 
                ID, ISBN);
        }
    }

    class Hardware : item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }


    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }
    */




    
    /*
    // for p3
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public Item GetItem ()
        {
            var newItem = new Item() { ID = 101, Name = "MyItem" };
            return newItem;
        }
    }


    class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("My ID is {0} and My ISBN is {1}",
                ID, ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }


    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }

    */







    // for p4
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static Item GetItem()
        {
            var newItem = new Item() { ID = 101, Name = "MyItem" };
            return newItem;
        }
    }


    class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("My ID is {0} and My ISBN is {1}",
                ID, ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }


    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }

}