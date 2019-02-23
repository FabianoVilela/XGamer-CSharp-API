using System;
using XGamer.Domain.Arguments.Player;
using XGamer.Domain.Interfaces.Repositories;
using XGamer.Domain.Interfaces.Services;

namespace XGamer.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse Add(AddPlayerRequest request)
        {
            var id = _repositoryPlayer.Add(request);

            return new AddPlayerResponse(id, "Player added!");
        }

        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            if(request == null)
            {
                throw new Exception("Authenticate is required!");
            }

            // TODO: Use Notification Pattner
            if(string.IsNullOrEmpty(request.Email))
            {
                throw new ArgumentNullException(request.Email, "Email is required!");
            }

            // TODO: Use Notification Pattner
            if (string.IsNullOrEmpty(request.Password))
            {
                throw new ArgumentNullException(request.Password, "Password is required!");
            }

            return _repositoryPlayer.Authenticate(request);
        }
    }
}
