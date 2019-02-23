using XGamer.Domain.Arguments.Platform;
using XGamer.Domain.Entities;

namespace XGamer.Domain.Interfaces.Services
{
    public interface IServicePlatform
    {
        AddPlatformResponse Add(AddPlatformRequest request);
    }
}
