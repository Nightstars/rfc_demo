using System;
using SapNwRfc;
namespace rfc_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "AppServerHost=xx; SystemNumber=xx; User=xx; Password=xx; Client=xx; Language=ZH; PoolSize=5; Trace=8";
                using var connection = new SapConnection(connectionString);
                connection.Connect();
                using var someFunction = connection.CreateFunction("ZMDG_MDATA_INFO");
                var result = someFunction.Invoke<FunctionResult>(new FunctionParameters
                {
                    Ibukrs = "1010",
                    Iztype = "2",
                    Izdata = "20200801",
                    Iztime = "00:00:00"
                });
                Console.WriteLine(result);
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
