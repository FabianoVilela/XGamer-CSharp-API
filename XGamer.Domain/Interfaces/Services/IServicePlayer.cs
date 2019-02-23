using System;
using XGamer.Domain.Arguments.Player;

namespace XGamer.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        AddPlayerResponse Add(AddPlayerRequest request);
    }
}
