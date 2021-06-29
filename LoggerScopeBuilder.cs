using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace AspNetCore.StructuredLogging.Extensions
{
    public class LoggerScopeBuilder
    {
        readonly List<KeyValuePair<string, object>> _properties = new();
        readonly ILogger _logger;

        public LoggerScopeBuilder(ILogger logger)
        {
            _logger = logger;
        }

        public LoggerScopeBuilder WithProperty(string propertyName, object propertyValue)
        {
            _properties.Add(new KeyValuePair<string, object>(propertyName, propertyValue));
            return this;
        }

        public IDisposable Begin() => _logger.BeginScope(_properties);
    }

    public static class LoggerScopeBuilderExtensions
    {
        public static LoggerScopeBuilder CreateScope(this ILogger logger) => new(logger);
    }
}
