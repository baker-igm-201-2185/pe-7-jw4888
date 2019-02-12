//Jixian Wang
//Wang_PE8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wang_PE8
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new potion 
            Potion myCustomPotion = new Potion("green", 78.20, "Speed Potion", "Make people faster", 7);
            //print
            myCustomPotion.PrintPotion();

            //create default potion
            Potion defaultPotion = new Potion();
            //print
            defaultPotion.PrintPotion();

            //use potion
            myCustomPotion.UsePotion();
            //print out
            myCustomPotion.PrintPotion();
        }
    }
}
