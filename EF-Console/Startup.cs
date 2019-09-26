using EF_Console.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Data.SqlClient;
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

                Console.WriteLine("start");
                //Task.Delay(TimeSpan.FromSeconds(5));


                Task1();
                Task2();







                Console.WriteLine("stop");

            }
            catch (Exception ex)
            {
                Console.WriteLine("程序异常:{0}", ex.Message);
            }
            Console.WriteLine("complete!");
            Console.ReadKey();
        }//MainAsync



        public static void Task1()
        {
            Console.WriteLine("start running task 1");
            Thread.Sleep(3000);
            Console.WriteLine("task 1 complete");
        }

        public static void Task2()
        {
            Console.WriteLine("start running task 2");
            Thread.Sleep(3000);
            Console.WriteLine("task 2 complete");
        }









        //public static async Task CreateAndQuery()
        //{
        //    using (var context = new AppDbContextFactory().CreateDbContext())
        //    {
        //        var data = await context.Set<Account>().FindAsync("123");
        //        Console.WriteLine(data.Name);
        //    }
        //}
    }
}
