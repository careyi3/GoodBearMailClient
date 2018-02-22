using System;
using System.Configuration;

namespace GoodBearMailClient
{
    public class SmtpSettingsService : ISmtpSettingsService
    {

        private ISmtpSettings _smtpSettingsConfig;

        public SmtpSettingsService(ISmtpSettings smtpSettings)
        {
            _smtpSettingsConfig = smtpSettings;
        }

        public ISmtpSettings SmtpSettingsConfig { get { return _smtpSettingsConfig; } }

    }
}