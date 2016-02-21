using Ninject.Modules;

namespace TwilioConsole
{
    class NinjectBootstrapModule : NinjectModule
    {
        public NinjectBootstrapModule() {}

        public override void Load()
        {
            Bind<ISmsMessage>().To<SmsMessage>();
            Bind<IPrompter>().To<Prompter>();
        }
    }
}
