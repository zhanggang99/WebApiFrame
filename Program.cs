using Microsoft.AspNetCore.Hosting;

namespace WebApiFrame
{
    //应用程序入口
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
            host.Run();
        }
    }
}
