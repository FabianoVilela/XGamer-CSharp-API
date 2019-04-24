using System;
using System.Collections.Generic;
using System.Text;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGamer.Domain.Resources;

namespace XGamer.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this)
                .IfNotEmail(address, Messages.RES_0_IS_INVALID.ToFormat("Email"))
                .IfNullOrEmpty(address, string.Format(Messages.RES_0_IS_REQUIRED.ToFormat("Email")));
        }

        public string Address { get; private set; }
    }
}
