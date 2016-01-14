using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }

        private IExtensionManager manager;

        public LogAnalyzer()
        {
            manager = new ExtensionManager();
        }

        public IExtensionManager ExtensionManager
        {
            get { return manager; }
            set { manager = value; }
        }

        public bool IsValidLogFileName(string fileName)
        {
            //WasLastFileNameValid = false;

            //if (string.IsNullOrEmpty(fileName))
            //{
            //    throw new ArgumentException("filename has to be provided");
            //}
            //if (!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            //{
            //    return false;
            //}

            WasLastFileNameValid = true;
            //return true;            

            return manager.IsValid(fileName);

        }

    }
}
