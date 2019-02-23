using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Arguments.Player;

namespace XGamer.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        Guid Add(AddPlayerRequest request);
    }
}
