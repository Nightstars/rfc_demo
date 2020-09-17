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
                string connectionString = "AppServerHost=192.168.95.20; SystemNumber=00; User=ZBT_RFC; Password=Zbt_rfc123; Client=310; Language=ZH; PoolSize=5; Trace=8";
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
