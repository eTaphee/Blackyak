using System.Configuration;

namespace Blackyak.Core.Configuration
{
    public static class AppSetting
    {
        public static UBConfigSection UBConfig { get; }

        static AppSetting()
        {
            UBConfig = ConfigurationManager.GetSection("upbit") as UBConfigSection;
        }

        public static void Save()
        {

        }
    }
}
