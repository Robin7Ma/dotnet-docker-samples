using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using RTDB.SDK;


namespace aspnetapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }


        private void CreatePIDBConnection(String DBType, string ServerIP, string ServerUser, string ServerPassword)
        {
            string key = DBType + "~/" + ServerIP + "~/" + ServerUser + "~/" + ServerPassword;

            RTDBInterface piconnection = RTDBInterface.CreateInstance(DBType, ServerIP, ServerUser, ServerPassword);
        }
    }
}
