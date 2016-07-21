using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Services
{
    class CalcService : ICalcService
    {
        ILogService _logger;
        public CalcService(ILogService logger)
        {
            _logger = logger;
        }

        public float? Calculate(float? arg1, float? arg2)
        {
            float? result = null;
            if (arg1.HasValue && arg2.HasValue)
                result = (arg1.Value + arg2.Value);
            else
                result = null;

            _logger.LogOperation(string.Format("Arg1 - {0}, Arg2 - {1}, Result - {2}", arg1, arg2, result));

            return result;
        }
    }
}
