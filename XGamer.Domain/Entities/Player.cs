using System;
using prmToolkit.NotificationPattern;
using XGamer.Domain.Enums;
using XGamer.Domain.Resources;
using XGamer.Domain.ValueObjects;

namespace XGamer.Domain.Entities
{
    public class Player : Notifiable
    {
        public Player(Email email, string password)
        {
            Password = password;
            Email = email;

            new AddNotifications<Player>(this)
                .IfNullOrEmpty(password, string.Format(Messages.RES_0_IS_REQUIRED, "Password"))
                .IfLengthLowerThan(password, 6, Messages.RES_PASSWORD_MUST_BE_GREAT_THAN_6);
        }

        public Player (PlayerName name, Email email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Guid Id { get; set; }
        public PlayerName Name { get; private set; }
        public Email Email { get; private set; }
        public PlayerStatus Status { get; private set; } = 0;
        public string Password { get; private set; }
    }
}
