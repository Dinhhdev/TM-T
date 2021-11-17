using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuoiTH2.helper
{
    public static class Configuration
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;

        // Static constructor for setting the readonly static members. 
        static Configuration()
        {
            var config = GetConfig();
            ClientId = config["clientId"];
            ClientSecret = config["clientSecret"];
        }


        public static Dictionary<string, string> GetConfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        // Create accessToken 
        private static string GetAccessToken()
        {
                           
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret,
GetConfig()).GetAccessToken();
            return accessToken;
        }

        // Returns APIContext object 
        public static APIContext GetAPIContext()
        {
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();

            return apiContext;
        }
    }
}