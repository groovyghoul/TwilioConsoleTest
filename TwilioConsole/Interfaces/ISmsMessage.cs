namespace TwilioConsole.Interfaces
{
    public interface ISmsService
    {
        string Message { get; set; }
        string TextNumber { get; set; }

        void Send();
    }
}