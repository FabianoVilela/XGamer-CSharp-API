using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Resources;

namespace XGamer.Domain.ValueObjects
{
    public class PlayerName : Notifiable
    {
        public PlayerName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            new AddNotifications<PlayerName>(this)
                .IfNullOrInvalidLength(x => x.FirstName, 3, 50, Messages.RES_0_IS_REQUIRED_AND_MUST_CONTAIN_BETWEEN_1_AND_2_CHARACTERS.ToFormat("First name", 3, 50))
                .IfNullOrInvalidLength(x => x.LastName  , 3, 50, Messages.RES_0_IS_REQUIRED_AND_MUST_CONTAIN_BETWEEN_1_AND_2_CHARACTERS.ToFormat("Last name", 3, 50));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
