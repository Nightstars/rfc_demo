using System;
using System.Collections.Generic;
using System.Text;
using SapNwRfc;
namespace rfc_demo
{
    class FunctionParameters
    {
        [SapName("I_BUKRS")]
        public string Ibukrs { get; set; }
        [SapName("I_ZTYPE")]
        public string Iztype { get; set; }
        [SapName("I_MDATA")]
        public string Imdata { get; set; }
        [SapName("I_ZDATA")]
        public string Izdata { get; set; }
        [SapName("I_ZTIME")]
        public string Iztime { get; set; }
    }
}
