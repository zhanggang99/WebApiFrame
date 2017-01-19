using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiFrame{
    public class Startup{

        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();//注入mvc框架
        }
        public void Configure(IApplicationBuilder app){
            // app.Run(context => {
            //     return context.Response.WriteAsync("Hello world");
            // });
            app.UseMvc();//添加mvc中间件
        }


    }

}