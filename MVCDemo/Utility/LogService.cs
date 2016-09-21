using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Utility
{
    public class LogService
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
    }
}