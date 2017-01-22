using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace WebApiFrame{
    public class Startup{

        public void ConfigureServices(IServiceCollection services){
            //注入mvc框架
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app,ILoggerFactory loggerFactory){
            // app.Run(context => {
            //     return context.Response.WriteAsync("Hello world");
            // });

            //添加日志支持
            //loggerFactory.AddConsole(LogLevel.Warning);
            //loggerFactory.AddDebug();

            //使用Filter设置日志级别
            loggerFactory.WithFilter(new FilterLoggerSettings(){
                {"Microsoft",LogLevel.Warning},
                {"WebApiFrame",LogLevel.Error}
            }).AddConsole();

            //添加ILog日志支持
            loggerFactory.AddNLog();
            //添加mvc中间件
            app.UseMvc();
        }


    }

}