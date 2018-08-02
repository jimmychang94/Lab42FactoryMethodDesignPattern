using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    public class Resume : Documents
    {
        public override Pages CreateDocument(string pageType)
        {
            Console.WriteLine($"Creating your resume based off of your {pageType} . . . ");
            Console.WriteLine("Making it professional . . . ");
            return ResumeFactory.CreatePages(pageType);
        }
    }
}
