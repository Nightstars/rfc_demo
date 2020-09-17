using SapNwRfc;
using System;
using System.Collections.Generic;
using System.Text;

namespace rfc_demo
{
    class ZMDGS003
    {
        [SapName("MDATA")]
        public string Mdata { get; set; }
        [SapName("MEINST")]
        public string Meinst { get; set; }
        [SapName("GROES")]
        public string Groes { get; set; }
        [SapName("ZSPM")]
        public string Zspm { get; set; }
        [SapName("MAKTX")]
        public string Maktx { get; set; }
        [SapName("BUKRS")]
        public string Bukrs { get; set; }
    }
}
