using XGamer.Domain.Interfaces.Arguments;
using XGamer.Domain.ValueObjects;

namespace XGamer.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse : IResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
