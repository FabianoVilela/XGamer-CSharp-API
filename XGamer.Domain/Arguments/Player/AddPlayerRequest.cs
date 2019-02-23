using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Interfaces.Arguments;
using XGamer.Domain.ValueObjects;

namespace XGamer.Domain.Arguments.Player
{
    public class AddPlayerRequest : IRequest
    {
        public PlayerName Name { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
    }
}
