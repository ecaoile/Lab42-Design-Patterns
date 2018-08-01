using System;
using Lab42_Design_Patterns.Classes;

namespace Lab42_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab 42!");
            ResumeBuilder();

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        static void ResumeBuilder()
        {
            Console.WriteLine("Let's create a resume!\n");
            Resume resume = new Resume();
            Page page1 = resume.PutTogetherPages("cover letter");
            Console.WriteLine();
            Page page2 = resume.PutTogetherPages("references");
            Console.WriteLine();
            Page page3 = resume.PutTogetherPages("work history");
            Console.WriteLine();
            Page page4 = resume.PutTogetherPages("summary");
            Console.WriteLine();
        }
    }
}
