//Jixian Wang
//Class name: Potion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wang_PE8
{
    class Potion
    {
        //parameter for this class
        string color;
        double strength;
        string name;
        string usage;
        int doses;

        //constructor
        public Potion(string pColor,double pStrength,string pName,string pUsage,int pDoses)
        {
            color = pColor;
            strength = pStrength;
            name = pName;
            usage = pUsage;
            doses = pDoses;
        }

        //overload constructor
        public Potion()
        {
            name = "Potion";
            strength = 50;
            color = "colorless";
            usage = "To cast a person";
            doses = 10;
        }

        //use potion
        public void UsePotion()
        {
            //doses -1
            doses--;
            Console.WriteLine("Using potion... {0} doses left.", doses);
        }

        //print out 
        public void PrintPotion()
        {
            Console.WriteLine("Potion:");
            Console.WriteLine("\tName: {0}",name);
            Console.WriteLine("\tStength: {0}", strength);
            Console.WriteLine("\tColor: {0}", color);
            Console.WriteLine("\tUsage: {0}", usage);
            Console.WriteLine("\tDoses: {0}", doses);

        }
    }
}
