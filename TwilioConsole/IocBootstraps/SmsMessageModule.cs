using Ninject.Modules;
using TwilioConsole.Interfaces;
using TwilioConsole.Services;

namespace TwilioConsole.IocBootstraps
{
    public class SmsMessageModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISmsService>().To<SmsService>();
        }
    }
}
