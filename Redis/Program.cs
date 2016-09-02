using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Saving random data in cache");
            program.SaveBigData();

            Console.WriteLine("Reading data from cache");
            program.ReadData();

            Console.ReadLine();
        }


        public void ReadData()
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            // Simple get of data types from the cache
            Console.WriteLine(cache.StringGet("key1"));
            Console.WriteLine(cache.StringGet("key2"));

        }

        public void SaveBigData()
        {
            //var devicesCount = 10000;
           
            var cache = RedisConnectorHelper.Connection.GetDatabase();

            cache.StringSet("key1", "value");
            cache.StringSet("key2", 25);

           

        }
    }
}
