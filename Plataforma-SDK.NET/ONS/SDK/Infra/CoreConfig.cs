using Microsoft.Extensions.Configuration;

namespace ONS.SDK.Infra
{
    public class CoreConfig : BaseServiceConfig
    {
        public CoreConfig (IConfiguration conf) {
            this.Host = conf.GetValue ("COREAPI_HOST", "apicore");
            this.Scheme = conf.GetValue ("COREAPI_SCHEME", "http");
            this.Port = conf.GetValue ("COREAPI_PORT", "9110");
        }

        public CoreConfig(){}
    }
}