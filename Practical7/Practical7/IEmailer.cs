namespace Practical7
{
    public interface IEmailer
    {
        void SendEmail(IPerson person, string message);
    }
}