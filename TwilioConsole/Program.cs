using Ninject;

namespace TwilioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new NinjectBootstrapModule());
            IPrompter prompter = kernel.Get<IPrompter>();
            ISmsMessage smsMessage = kernel.Get<ISmsMessage>();

            smsMessage.TextNumber = prompter.Prompt("Enter text number");
            smsMessage.Message = prompter.Prompt("Enter message");

            smsMessage.Send();
        }
    }
}
