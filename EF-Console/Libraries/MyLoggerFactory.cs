using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace EF_Console.Libraries
{
    public class MyLoggerFactory : ILoggerFactory
    {
        private MyLogger _MyLogger;
        public void AddProvider(ILoggerProvider provider)
        {

        }

        public ILogger CreateLogger(string categoryName)
        {
            if (_MyLogger == null)
                _MyLogger = new MyLogger();
            return _MyLogger;
        }

        public void Dispose()
        {

        }
    }

    public class MyLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
            File.AppendAllText(Path.Combine(logDir, DateTime.Now.ToString("yyyy-MM-dd") + ".txt"), formatter(state, exception));
        }
    }
}
