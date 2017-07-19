using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;
using TestStack.Seleno.Configuration.WebServers;

namespace BDD.Seleno.UITestSample
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl;

        static BrowserHost()
        {

            // Note, for local dev, you will do something like this...
            /// Instance.Run("MyLocalWebSiteFolderName", 4223, config =>

            // This is to run against a remote site
            Instance.Run(config =>
            {
                config
                    .WithRemoteWebDriver(BrowserFactory.Chrome)
                    .WithWebServer(new InternetWebServer("https://nationalcareersservice.direct.gov.uk"));
            }); 

            RootUrl = Instance.Application.Browser.Url;
        }
    }
}
