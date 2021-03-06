﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class ExtensionManager : IExtensionManager
    {
        public bool willBeValid = false;
        public Exception willThrow = null;

        public bool IsValid(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("filename has to be provided");
            }
            if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}
