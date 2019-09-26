using EF_Console.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading;

namespace EF_Console
{
    class Startup
    {
        public static async Task MainAsync(string[] args)
        {
            try
            {






            }
            catch (Exception ex)
            {
                Console.WriteLine("程序异常:{0}", ex.Message);
            }
            Console.WriteLine("complete!");
            Console.ReadKey();
        }//MainAsync
    }
}
