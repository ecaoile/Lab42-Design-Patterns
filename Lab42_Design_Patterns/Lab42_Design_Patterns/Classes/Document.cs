using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Design_Patterns.Classes
{
    public abstract class Document
    {
        public abstract Page CreatePage(string type);

        public Page PutTogetherPages(string type)
        {
            Page page = CreatePage(type);

            page.GetPaper();
            page.Type();
            page.Print();
            page.Package();

            return page;
        }
    }
}
