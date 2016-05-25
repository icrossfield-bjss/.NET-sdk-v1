using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMA.MobileConnect.Demo.Config
{
    public static class DemoConfiguration
    {
        public static MobileConnectConfig Config { get; set; }

        static DemoConfiguration()
        {
            Config = new MobileConnectConfig
            {
                ClientId = "66742a85-2282-4747-881d-ed5b7bd74d2d",
                ClientSecret = "f15199f4-b658-4e58-8bb3-e40998873392",
                RedirectUrl = "http://localhost:8001/mobileconnect.html",
                DiscoveryUrl = "http://discovery.sandbox2.mobileconnect.io/v2/discovery/",
            };
        }
}
}
