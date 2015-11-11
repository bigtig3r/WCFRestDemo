using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRestDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFRestDemo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFRestDemo.svc or WCFRestDemo.svc.cs at the Solution Explorer and start debugging.
    public class WCFRestDemo : IWCFRestDemo
    {
        public string getMessage()
        {
            return "Hello";
        }
        public string postMessage(string userName)
        {
            return string.Format("Wellcom {0}", userName);
        }
    }
}
