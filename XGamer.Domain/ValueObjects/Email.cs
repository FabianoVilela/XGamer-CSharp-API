using System;
using System.Collections.Generic;
using System.Text;
using prmToolkit.NotificationPattern;
using XGamer.Domain.Resources;

namespace XGamer.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this)
                .IfNotEmail(address, string.Format(Messages.RES_0_IS_INVALID, "Email"))
                .IfNullOrEmpty(address, string.Format(Messages.RES_0_IS_REQUIRED, "Email"));
        }

        public string Address { get; private set; }
    }
}
