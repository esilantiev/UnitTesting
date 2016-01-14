using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class TestabaleLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        public IExtensionManager manager;

        public TestabaleLogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        protected override IExtensionManager GetManager()
        {
            return manager;
        }
    }
}
