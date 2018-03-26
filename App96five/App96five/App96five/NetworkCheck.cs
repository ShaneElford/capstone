using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App96five
{
    public class NetworkCheck
    {
        public static bool IsInternet()
        {
            return CrossConnectivity.Current.IsConnected;
        }

    }
}
