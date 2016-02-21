using System;
using System.Configuration;
using Twilio;

namespace TwilioConsole
{
    public class SmsMessage : ISmsMessage
    {
        public string Message { get; set; }
        public string TextNumber { get; set; }

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
            }

        }
    }
}
