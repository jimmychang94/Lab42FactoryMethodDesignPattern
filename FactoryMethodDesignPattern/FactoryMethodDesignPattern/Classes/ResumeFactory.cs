using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    public class ResumeFactory
    {
        public static Pages CreatePages (string pageType)
        {
            Pages page = null;
            switch (pageType.ToLower())
            {
                case "experience":
                    Console.WriteLine("Describing your work experience . . . ");
                    page = new WorkHistory();
                    break;
                case "education":
                    Console.WriteLine("Embelishing your education . . . ");
                    page = new EducationalHistory();
                    break;
                default:
                    break;
            }
            return page;
        }
    }
}
