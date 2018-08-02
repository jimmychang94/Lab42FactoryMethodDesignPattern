using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Classes
{
    public abstract class Documents
    {
        public abstract Pages CreateDocument(string pageType);
    }
}
