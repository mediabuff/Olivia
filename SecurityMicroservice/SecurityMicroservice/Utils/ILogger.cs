namespace SecurityMicroservice.Utils
{
    public interface ILogger
    {
        void AddProvider(ILoggerProvider provider);
    }
}
