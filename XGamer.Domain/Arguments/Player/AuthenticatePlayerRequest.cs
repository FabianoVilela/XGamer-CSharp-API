using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Interfaces.Arguments;

namespace XGamer.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
