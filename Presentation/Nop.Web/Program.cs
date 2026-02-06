using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Nop.Core.Configuration;
using Nop.Web.Framework.Infrastructure.Extensions;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Configuration.AddJsonFile(NopConfigurationDefaults.AppSettingsFilePath, true, true);
if (!string.IsNullOrEmpty(builder.Environment?.EnvironmentName))
{
    var path = string.Format(NopConfigurationDefaults.AppSettingsEnvironmentFilePath, builder.Environment.EnvironmentName);
    builder.Configuration.AddJsonFile(path, true, true);
}
builder.Configuration.AddEnvironmentVariables();

//Add services to the application and configure service provider
builder.Services.ConfigureApplicationServices(builder);

var app = builder.Build();


app.UseRouting();

//Configure the application HTTP request pipeline
app.ConfigureRequestPipeline();
app.StartEngine();

app.Run();
