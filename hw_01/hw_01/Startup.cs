using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.Map("/home", (home) =>
             {
                 home.Run(async (ctx) =>
                 {
                     await ctx.Response.WriteAsync($"<h1>Home page</h1>" +
                         $"<h3>The page was visited time</h3>");
                 });
 
             });


            app.Map("/about", (home) =>
            {
                home.Run(async (ctx) =>
                {
                    await ctx.Response.WriteAsync($"<h1>About page</h1>" +
                        $"<h3>The page was visited time</h3>");
                });

            });

            app.Map("/contacts", (home) =>
            {
                home.Run(async (ctx) =>
                {
                    await ctx.Response.WriteAsync($"<h1>Contacts page</h1>" +
                        $"<h3>The page was visited time</h3>");
                });

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
