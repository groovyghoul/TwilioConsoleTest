using Ninject.Modules;
using TwilioConsole.Interfaces;
using TwilioConsole.Services;

namespace TwilioConsole.IocBootstraps
{
    public class LoggingModule : NinjectModule
    {
        public override void Load()
        {
            ILoggingService logger = LoggingService.GetLoggingService();
            Bind<ILoggingService>().ToConstant(logger);
        }
    }
}
