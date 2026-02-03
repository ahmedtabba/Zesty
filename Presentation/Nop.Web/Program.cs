using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Nop.Core.Configuration;
using Nop.Web.Framework.Infrastructure.Extensions;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

// Ensure bundles folder exists early, before WebOptimizer tries to create files
try
{
    var bundlesPath = Path.Combine(env.WebRootPath ?? Path.Combine(env.ContentRootPath, "wwwroot"), "bundles");
    if (!Directory.Exists(bundlesPath))
        Directory.CreateDirectory(bundlesPath);
}
catch (Exception ex)
{
    // Do not throw — log and continue so developer can fix permissions without crashing the app.
    Console.WriteLine($"Warning: could not create bundles folder: {ex.Message}");
}

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

app.UseWebOptimizer();   // make sure this runs before UseStaticFiles()
app.UseStaticFiles();
app.UseRouting();

//Configure the application HTTP request pipeline
app.ConfigureRequestPipeline();
app.StartEngine();

app.Run();
