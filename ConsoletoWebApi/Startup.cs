using ConsoletoWebApi.Services;
using Microsoft.VisualBasic;

namespace ConsoletoWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IProductService, ProductService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hell from the 1 1 \n");

            //    await next();

            //    await context.Response.WriteAsync("Hell from the 1 2 \n");
            //});

            //app.Map("/rifat", CutomCode);

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello run 1\n");
            //});


            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllers();
            });

        }

        //private void CutomCode(IApplicationBuilder app)
        //{

        //    app.Use(async (context, next) =>
        //    {
        //        await context.Response.WriteAsync("Hell from the 1000 \n");

        //        await next(context);
        //    });

        //}
    }
}
