using System;
using XGamer.Domain.Interfaces.Arguments;

namespace XGamer.Domain.Arguments.Platform
{
    public class AddPlatformResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
