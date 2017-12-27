using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace HelloWorld {
  public class Startup
  {
        // The startup class has a constructor that implements the IHostingEnvironment 
      public Startup(IHostingEnvironment env)
      {
            var envName = env.EnvironmentName;
            var appName = env.ApplicationName;
            var contentRootFileProvider = env.ContentRootFileProvider;
            var contentRoot = env.ContentRootPath;
            var webRootFile = env.WebRootFileProvider;
            var webRootPath = env.WebRootPath;
      }        
       
      public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
      {
            var appServices = app.ApplicationServices;  //service container
            var appProperties = app.Properties;

            // stuff for logging
            //loggerFactory.

            //https://msdn.microsoft.com/en-us/magazine/hh456401.aspx
            //
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(string.Format("Hello, world!\n" +
                    "Env:{0}\n" + "App:{1}\n" + "contentRootFileProvider:{2}\n" + "contentRootPath:{3}\n" + "webRootFileProvider:{4}\n" + "webRootPath:{5}\n", 
                    env.EnvironmentName, env.ApplicationName, env.ContentRootFileProvider, env.ContentRootPath, env.WebRootFileProvider, env.WebRootPath));
            });
      }
  }   
}