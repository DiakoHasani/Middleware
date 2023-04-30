using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class LogHelper
    {
        public static void LogException(this ILogger logger, Exception ex)
        {
            var state = new Dictionary<string, string>
            {
                { "Source", ex.Source??"" },
                { "StackTrace", ex.StackTrace??"" },
                { "HelpLink", ex.HelpLink??"" },
                { "HResult", ex.HResult.ToString() },
            };
            using (logger.BeginScope(state))
            {
                logger.LogError(ex.Message);
            }
        }
    }
}
