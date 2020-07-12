using System;
using ETAPI;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BankAlert.SFMCService
{
    public class AlertService
    {
        private SoapClient client = new SoapClient();
        private static string GetToken(string clientId, string clientSecret)
        {
            
            return "";
        }

        public AlertService()
        {
            
        }
        public void GetDataExtension()
        {

            client.ClientCredentials.UserName.UserName = "rameshsinha";
            client.ClientCredentials.UserName.Password = "welcome@3le";
            APIObject[] Results;
            String requestID;
            String status ;
            RetrieveRequest1 rr1 = new RetrieveRequest1();
            RetrieveRequest rr = new RetrieveRequest();
            rr.ObjectType = "DataExtensionObject[Alert_Inbox]";
            rr.Properties = new string[]{
                "Alert_Category","Alert_Subject"
            };
            rr1.RetrieveRequest = rr;
            SimpleFilterPart sf = new SimpleFilterPart();
            sf.SimpleOperator = SimpleOperators.equals;
            sf.Property = "ET_Surrogate_ID";

           //var results =   client.RetrieveAsync(rr1);
           var result =  Task.Run(async ()=> client.RetrieveAsync(rr1));
           var values = result.GetAwaiter().GetResult().GetAwaiter().GetResult();
            }
    }
}