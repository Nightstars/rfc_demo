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

/******************* rfc .net core support ********************
   Author(s):   christ chang
   Description: rfc .net core support
   github: https://github.com/Nightstars/rfc_demo
   thanks: huysentruitw and his work 
*******************************************************************************/
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
