using System.Configuration;

namespace Blackyak.Core.Configuration
{
    public class UBConfigSection : ConfigurationSection
    {
        string accessKey = "Input your access key";
        string secretKey = "Input your secret key";

        [ConfigurationProperty(nameof(accessKey), IsRequired = true)]
        public string AccessKey
        {
            get
            {
                return accessKey = (string)base[nameof(accessKey)];
            }
            set
            {
                accessKey = value;
            }
        }

        [ConfigurationProperty(nameof(secretKey), IsRequired = true)]
        public string SecretKey
        {
            get
            {
                return secretKey = (string)base[nameof(secretKey)];
            }
            set
            {
                secretKey = value;
            }
        }
    }
}
