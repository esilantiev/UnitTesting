using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            return GetManager().IsValid(fileName);
        }

        protected virtual IExtensionManager GetManager()
        {
            return new ExtensionManager();
        }
    }
}
