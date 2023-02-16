using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums._01_Basic_example
{
    enum UshortEnum : ushort
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 100,
        OutlierReading = 200,
        //NotPossibleValue = 1000000000 //Error
    }
}

/*
You can also explicitly specify the associated constant values 
*/