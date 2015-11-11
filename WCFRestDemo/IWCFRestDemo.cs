using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRestDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFRestDemo" in both code and config file together.
    [ServiceContract]
    public interface IWCFRestDemo
    {
        [OperationContract]
        [WebGet(RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json)]
        string getMessage();
        [OperationContract]
        [WebInvoke(Method="POST",
            RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json)]
        string postMessage(string userName);
    }
}
