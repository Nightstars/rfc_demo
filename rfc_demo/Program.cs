/* -----------------------------------------------------------------------------
 1.    INTRODUCTION
This is an enlightenment program based on the SapNwRfc project, about how
to call RFC in .net core.  You can modify and distribute copies of this
program at will, but there is one thing you must do and acknowledge : 
No matter what purpose you use, you must indicate the source of this code.
star and fork will be better
2.    CONTACT INFORMATION
chrsitzhangowner@gmail.com
----------------------------------------------------------------------------- */

/************************ rfc .net core support *************************
   Author(s):   christ chang
   Description: rfc .net core support
   github: https://github.com/Nightstars/rfc_demo
   thanks: huysentruitw and his work 
*******************************************************************************/
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
                Console.WriteLine("/************************ rfc .net core support *************************");
                Console.WriteLine("   Author(s):   christ chang");
                Console.WriteLine("   Description: rfc .net core support");
                Console.WriteLine("   github: https://github.com/Nightstars/rfc_demo");
                Console.WriteLine("   thanks: huysentruitw and his work ");
                Console.WriteLine("************************************************************************/");
                //define connect string 
                string connectionString = "AppServerHost=192.168.95.20; SystemNumber=00; User=ZBT_RFC; Password=Zbt_rfc123; Client=310; Language=ZH; PoolSize=5; Trace=8;";
                //structure rfc connection
                using var connection = new SapConnection(connectionString);
                //open rfc connection
                connection.Connect();
                //structure call function by rfc target fun
                using var someFunction = connection.CreateFunction("ZMDG_MDATA_INFO");
                //call remote rfc functon with input parameter constructor and get fun result
                rfc_demo.FunctionResult result= someFunction.Invoke<FunctionResult>(new FunctionParameters
                {
                    Ibukrs = "1010",
                    Iztype = "2",
                    Izdata = "20200801",
                    Iztime = "00:00:00"
                });
                //print result in console 
                foreach(ZMDGS003 item in result.result)
                {
                    Console.WriteLine(item.Mdata);
                    Console.WriteLine(item.Meinst);
                    Console.WriteLine(item.Groes);
                    Console.WriteLine(item.Zspm);
                    Console.WriteLine(item.Maktx);
                    Console.WriteLine(item.Bukrs);
                    Console.WriteLine();
                }            
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine("Oh no: "+e.Message);
                Console.ReadKey();
            }
        }
    }
}
