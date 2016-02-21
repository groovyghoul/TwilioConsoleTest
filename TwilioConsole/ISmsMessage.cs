namespace TwilioConsole
{
    public interface ISmsMessage
    {
        string Message { get; set; }
        string TextNumber { get; set; }

        void Send();
    }
}