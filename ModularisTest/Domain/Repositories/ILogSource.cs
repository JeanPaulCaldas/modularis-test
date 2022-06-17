namespace ModularisTest.Domain.Repositories
{
    internal interface ILogSource
    {
        void Log(Message message);
    }
}
