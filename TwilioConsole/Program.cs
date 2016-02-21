using Ninject;
using TwilioConsole.Interfaces;
using TwilioConsole.IocBootstraps;

namespace TwilioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new SmsMessageModule(),
                                                new PrompterModule(),
                                                new LoggingModule());

            IPrompterService prompter = kernel.Get<IPrompterService>();
            ISmsService smsMessage = kernel.Get<ISmsService>();

            smsMessage.TextNumber = prompter.Prompt("Enter text number");
            smsMessage.Message = prompter.Prompt("Enter message");

            smsMessage.Send();
        }
    }
}
