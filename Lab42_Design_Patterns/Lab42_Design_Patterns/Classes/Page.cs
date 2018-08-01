using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Design_Patterns.Classes
{
    public abstract class Page
    {
        public void GetPaper()
        {
            Console.WriteLine("Grabbing paper for the page.");
        }

        public void Type()
        {
            Console.WriteLine("Typing out the text for the page.");
        }

        public void Print()
        {
            Console.WriteLine("Printing out the page.");
        }

        public void Package()
        {
            Console.WriteLine("Putting the paper in a folder.");
        }
    }
}
