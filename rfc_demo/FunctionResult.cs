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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SapNwRfc;
namespace rfc_demo
{
    class FunctionResult 
    {
        [SapName("ZTABLE")]
        public ZMDGS003[] result { get; set; }
    }
}
