using System;
using System.Collections.Generic;
using System.Text;
using SapNwRfc;
namespace rfc_demo
{
    class FunctionResult
    {
        [SapName("ZTABLE")]
        public ZMDGS003 result { get; set; }
    }
}
