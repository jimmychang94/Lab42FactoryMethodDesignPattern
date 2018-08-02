using FactoryMethodDesignPattern.Classes;
using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ResumeExample();
            FinancialReportExample();
        }

        static void ResumeExample()
        {
            Pages page = null;
            Resume resume = new Resume();
            page = resume.CreateDocument("experience");
        }

        static void FinancialReportExample()
        {
            Pages page = null;
            FinancialReport report = new FinancialReport();
            page = report.CreateDocument("Products");
        }
    }
}
