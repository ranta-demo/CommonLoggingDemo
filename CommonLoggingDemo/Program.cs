using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCommonLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog logger = LogManager.GetLogger(typeof(Program).FullName);

            try
            {
                throw new Exception("This is a test.");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            Console.WriteLine("Press any key to continue.");

            Console.Read();
        }
    }
}
