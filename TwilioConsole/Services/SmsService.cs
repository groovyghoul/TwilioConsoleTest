using System;
using System.Configuration;
using Twilio;
using TwilioConsole.Interfaces;

namespace TwilioConsole.Services
{
    public class SmsService : ISmsService
    {
        private readonly ILoggingService _logger;

        public string Message { get; set; }
        public string TextNumber { get; set; }

        public SmsService(ILoggingService logger)
        {
            _logger = logger;
        }

        public void Send()
        {
            var accountSid = ConfigurationManager.AppSettings["TWILIO_API_ACCOUNT_SID"];
            var authToken = ConfigurationManager.AppSettings["TWILIO_API_AUTH_TOKEN"];
            var fromNumber = ConfigurationManager.AppSettings["TWILIO_FROM_PHONE_NUMBER"];

            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(fromNumber, String.Format("+{0}", TextNumber), Message);

            if (message.RestException != null)
            {
                var error = message.RestException.Message;
                // handle the error ...
                _logger.Error(error);
            }
            else
                _logger.Info("Everything is groovy!");

        }
    }
}
