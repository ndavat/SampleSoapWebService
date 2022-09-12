using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SoapCore;
using SampleSoapWebService;
using SampleSoapWebService.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSoapCore();
builder.Services.TryAddSingleton<SampleService>();
builder.Services.AddMvc();
var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<SampleService>("/SampleWebService.asmx", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
});
app.MapGet("/", () => "Hello World!");
app.Run();