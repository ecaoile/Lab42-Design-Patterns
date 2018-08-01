using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42_Design_Patterns.Classes
{
    public abstract class Document
    {
        protected abstract Page CreatePage(string type);

        public Page PutTogetherPages(string type)
        {
            Page page = CreatePage(type);

            page.GetPaper();
            page.Print();
            page.Package();

            return page;
        }
    }
}
