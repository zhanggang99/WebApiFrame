using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApiFrame{
    public class HelloworldMiddleware{
        private readonly RequestDelegate _next;
        public HelloworldMiddleware(RequestDelegate next){
            _next=next;
        }
        public async Task Invoke(HttpContext context){
            await context.Response.WriteAsync("helle world");
            await _next(context);
        }
    }
}