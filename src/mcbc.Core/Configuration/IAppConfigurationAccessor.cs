using Microsoft.Extensions.Configuration;

namespace mcbc.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

