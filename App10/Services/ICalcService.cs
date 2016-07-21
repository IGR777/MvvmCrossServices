using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Services
{
    interface ICalcService
    {
        float? Calculate(float? arg1, float? arg2);
    }
}
