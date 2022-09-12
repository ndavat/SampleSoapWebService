using System.Xml.Linq;
using SampleSoapWebService.Models;
using System.ServiceModel;
namespace SampleSoapWebService.Services
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string name);
        [OperationContract]
        void XmlMethod(XElement xml);
        [OperationContract]
        string SampleOrderRequest(SampleRequest inputModel);
    }
    public class SampleService : ISampleService
    {
        public SampleService()
        {
            // Initialize any injected service here.
        }
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s;
        }
        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
        public string SampleOrderRequest(SampleRequest inputModel)
        {
            // Perform an action on inputModel.
            return inputModel.ToString();
        }
    }
}