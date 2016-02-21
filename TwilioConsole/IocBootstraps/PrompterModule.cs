using Ninject.Modules;
using TwilioConsole.Interfaces;
using TwilioConsole.Services;

namespace TwilioConsole.IocBootstraps
{
    public class PrompterModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrompterService>().To<PrompterService>();
        }
    }
}
