using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace AspNetCore.StructuredLogging.Extensions
{
    public static class LoggerExtensions
    {
        public static IDisposable BeginScopeWithProperty(this ILogger logger, string propertyName, object propertyValue) =>
            logger.BeginScope(new[] { new KeyValuePair<string, object>(propertyName, propertyValue) });
    }
}
