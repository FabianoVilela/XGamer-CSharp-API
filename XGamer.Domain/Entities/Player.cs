using System;
using XGamer.Domain.Enums;
using XGamer.Domain.ValueObjects;

namespace XGamer.Domain.Entities
{
    public class Player
    {
        public Player (PlayerName name, Email email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Guid Id { get; set; }
        public PlayerName Name { get; set; }
        public Email Email { get; set; }
        public PlayerStatus Status { get; set; }
        public string Password { get; private set; }
    }
}
