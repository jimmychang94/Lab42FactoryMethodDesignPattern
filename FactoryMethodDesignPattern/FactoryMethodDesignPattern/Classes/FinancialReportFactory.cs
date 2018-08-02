using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    public class FinancialReportFactory
    {
        public static Pages CreatePages(string pageType)
        {
            Pages page = null;
            switch (pageType.ToLower())
            {
                case "users":
                    Console.WriteLine("Finding the number of customers . . . ");
                    page = new Accounts();
                    break;
                case "products":
                    Console.WriteLine("Totaling the profit . . . ");
                    page = new Sales();
                    break;
                default:
                    break;
            }
            return page;
        }
    }
}
