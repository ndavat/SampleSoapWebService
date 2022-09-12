using System.Runtime.Serialization;
namespace SampleSoapWebService.Models;
[DataContract]
public class SampleRequest
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Description { get; set; }
    [DataMember]
    public string Action { get; set; }
    [DataMember]
    public DateTime ActionDate { get; set; }
}