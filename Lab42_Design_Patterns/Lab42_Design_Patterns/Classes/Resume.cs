using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Design_Patterns.Classes
{
    class Resume : Document
    {
        protected override Page CreatePage(string type)
        {
            Console.WriteLine("We are creating a page for a resume!");
            //return 
        }
    }
}
