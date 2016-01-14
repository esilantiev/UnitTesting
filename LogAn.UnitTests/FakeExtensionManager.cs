using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn.UnitTests
{
    internal class FakeExtensionManager:IExtensionManager
    {
        public bool willBeValid = false;
                

        public bool IsValid(string fileName)
        {
            return willBeValid;
        }
    }
}
