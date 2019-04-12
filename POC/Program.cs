using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace POC
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            if(redis.IsConnected)
            {
                Console.WriteLine("IsConnected");
            }
            else
            {
                Console.WriteLine("Service is unavailable");
            }
        }
    }
}
