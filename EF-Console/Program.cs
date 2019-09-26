using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EF_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //配置应用配置文件
            AppConfig.Config();
            Startup.MainAsync(args).GetAwaiter().GetResult();
            Console.WriteLine("----complete----");
            Console.ReadKey();
        }
    }
}
