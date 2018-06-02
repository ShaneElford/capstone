using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App96five
{
    public class NetworkCheck
    {
        public static string errorMessage = "testerror";
        public static bool IsInternet()
        {
            bool returnValue = false;
            try
            {
                returnValue = CrossConnectivity.Current.IsConnected;
                return returnValue;
            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

    }
}
