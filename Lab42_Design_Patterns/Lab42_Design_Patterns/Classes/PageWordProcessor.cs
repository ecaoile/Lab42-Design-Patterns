using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Design_Patterns.Classes
{
    public class PageWordProcessor
    {
        public static Page CreatePage(string pageType)
        {
            Console.WriteLine($"Creating a {pageType} page.");
            Page page = null;

            switch (pageType.ToLower())
            {
                case "cover letter":
                    page = new CoverLetter();
                    break;
                case "references":
                    page = new References();
                    break;
                case "work history":
                    page = new WorkHistory();
                    break;
                case "summary":
                    page = new Summary();
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
