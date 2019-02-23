using System;
using XGamer.Domain.Interfaces.Arguments;

namespace XGamer.Domain.Arguments.Player
{
    public class AddPlayerResponse : IResponse
    {
        Guid Id { get; set; }
        string Message { get; set; }

        public AddPlayerResponse(Guid id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}
