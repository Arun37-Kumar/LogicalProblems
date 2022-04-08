using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.NUnitTesting
{
    class VendingMachine
    {
        public static void CalculateNotes()
        {
            Console.WriteLine("Enter the Amount : ");
            int money = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1000,500,100,50,10,2,1 };
            int temp = money;
            for(int i = 0; i < notes.Length; i++)
            {
                int noOfNotes = temp / notes[i];
                Console.WriteLine("{0} Notes is : {1}",notes[i],noOfNotes);
                temp %= notes[i];
            }

        }
    }
}
