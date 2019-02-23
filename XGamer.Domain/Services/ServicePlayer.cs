using System;
using prmToolkit.NotificationPattern;
using XGamer.Domain.Arguments.Player;
using XGamer.Domain.Entities;
using XGamer.Domain.Interfaces.Repositories;
using XGamer.Domain.Interfaces.Services;
using XGamer.Domain.Resources;
using XGamer.Domain.ValueObjects;

namespace XGamer.Domain.Services
{
    public class ServicePlayer : Notifiable, IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse Add(AddPlayerRequest request)
        {
            Player player = new Player(request.Name, request.Email, request.Password);
            var id = _repositoryPlayer.Add(player);

            return new AddPlayerResponse(id, string.Format(Messages.RES_0_ADDED, "Player"));
        }

        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            if (request == null)
            {
                AddNotification("request", Messages.RES_INVALID_PARAMETERS);
            }

            Email email = new Email(request.Email);
            Player player = new Player(email, request.Password);

            AddNotifications(player, email);

            if (player.IsValid())
                return null;

            return _repositoryPlayer.Authenticate(player.Email.Address, player.Password);
        }
    }
}
