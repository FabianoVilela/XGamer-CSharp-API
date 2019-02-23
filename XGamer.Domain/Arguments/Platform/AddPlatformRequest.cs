using System;
using System.Collections.Generic;
using System.Text;
using XGamer.Domain.Interfaces.Arguments;

namespace XGamer.Domain.Arguments.Platform
{
    public class AddPlatformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
