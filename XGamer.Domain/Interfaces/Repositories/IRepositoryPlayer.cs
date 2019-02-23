using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Arguments.Player;
using XGamer.Domain.Entities;

namespace XGamer.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(string email, string password);
        Guid Add(Player player);
    }
}
