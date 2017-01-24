using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace WebApiFrame{
    public class Startup{

        //负责服务配置
        public void ConfigureServices(IServiceCollection services){
            //注入mvc框架
            services.AddMvc();
        }

        //请求管道配置
        public void Configure(IApplicationBuilder app,ILoggerFactory loggerFactory){
            // app.Run(context => {
            //     return context.Response.WriteAsync("Hello world");
            // });

            //添加日志支持
            loggerFactory.AddConsole(LogLevel.Warning);
            // loggerFactory.AddDebug();

            // //使用Filter设置日志级别
            // loggerFactory.WithFilter(new FilterLoggerSettings(){
            //     {"Microsoft",LogLevel.Warning},
            //     {"WebApiFrame",LogLevel.Information}
            // }).AddConsole();

            // //添加ILog日志支持
            // loggerFactory.AddNLog();
            
            // //添加自定义中间件
            // app.Run(async context => {
            //     await context.Response.WriteAsync("hello world");
            // });

            //只有Hello World!: Run的这种用法表示注册的此中间件为管道内的最后一个中间件，由它处理完请求后直接返回。
            //app.Run(async context => {await context.Response.WriteAsync("hello world too");});

            //添加自定义中间件
            // app.Use(async (context,next) => {
            //     await context.Response.WriteAsync("hello world 22222");
            //     await next();
            // });

            // app.Use(async (context,next)=>{
            //     await context.Response.WriteAsync("hello world too 22");
            // });

            //将中间件单独写成独立的类，通过UseMiddleware方法同样可以完成注册
            // app.UseMiddleware<HelloworldMiddleware>();
            // app.UseMiddleware<HelloworldTooMiddleware>();

            //Map方法主要通过请求路径和其他自定义条件过滤来指定注册的中间件，看起来更像一个路由
            //app.Map("/test",Maptest);
            
            // 添加自定义中间件
            //app.UseVisitLogger();

            //添加mvc中间件
            //app.UseMvc();
            app.UseMvcWithDefaultRoute();

        }
        // private static void Maptest(IApplicationBuilder app){
        //     app.Run(async context =>{
        //         await context.Response.WriteAsync("url is "+context.Request.PathBase.ToString());
        //     });
        // }
        

    }

}