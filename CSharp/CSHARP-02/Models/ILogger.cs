namespace CSHARP_02.Models
{
    // Gemaakt door Alexander
    public interface ILogger
    {
        void LogMessage(string message);
    }

    public class FileLogger : ILogger
    {
        private readonly string filePath = "log.txt";

        public void LogMessage(string message)
        {
            File.AppendAllText(filePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    public class MultiLogger : ILogger
    {
        private readonly List<ILogger> _loggers;

        public MultiLogger()
        {
            _loggers = new List<ILogger> { new FileLogger(), new ConsoleLogger() };
        }

        public void LogMessage(string message)
        {
            foreach (var logger in _loggers)
                logger.LogMessage(message);
        }
    }

}
