using System;
using ConsoletoWebApi;
using Microsoft.Extensions.Hosting;

CreateHostBuilder().Build().Run();


 static IHostBuilder CreateHostBuilder()=>
        Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(webHost =>
        {
            webHost.UseStartup<Startup>();
        });


