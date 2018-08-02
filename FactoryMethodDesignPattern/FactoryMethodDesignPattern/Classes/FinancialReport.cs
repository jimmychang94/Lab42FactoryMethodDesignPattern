using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    class FinancialReport : Documents
    {
        public override Pages CreateDocument(string pageType)
        {
            Console.WriteLine("Creating your financial report . . . ");
            return FinancialReportFactory.CreatePages(pageType);
        }
    }
}
