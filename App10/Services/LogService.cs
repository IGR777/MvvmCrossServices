using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10.Services
{
    class LogService : ILogService
    {

        List<string> _logs = new List<string>();
        public void LogOperation(string log)
        {
            _logs.Add(log);
        }
    }
}
