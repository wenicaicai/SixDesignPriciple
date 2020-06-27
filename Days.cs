using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SixDesignPrinciple
{
    public enum Days : Byte
    {
        [Description("周一")]
        Monday = 1,

        [Description("周二")]
        Tuesday = 2,

        [Description("周三")]
        Wednesday = 3,

        [Description("周四")]
        Thursday = 4,

        [Description("周五")]
        Friday = 5,

        [Description("周六")]
        Saturday = 6,

        [Description("周日")]
        Sunday = 7
    }
}
