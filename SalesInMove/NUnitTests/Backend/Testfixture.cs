using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NUnitTests.Backend
{
    public class Testfixture<TStartup> : IDisposable where TStartup : class
    {
        //create testserver which solves the application dependencies
        public readonly TestServer Server;
        public readonly HttpClient _client;

        public Testfixture()
        {
            var builder = new WebHostBuilder().UseContentRoot("..\\..\\..\\..\\..\\SalesInMove\\SalesInMove").UseStartup<TStartup>();
            Server = new TestServer(builder);

        }
        //C:\Users\Laptop\OneDrive\Desktop\IRL\SalesInMove\SalesInMove\SalesInMove.csproj



        public void Dispose()
        {
            _client.Dispose();
            Server.Dispose(;
        }
    }
}
