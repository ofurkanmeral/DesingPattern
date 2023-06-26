using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.ProxyDesingPattern.Interface
{
    public interface ILogger
    {
        void Log(string message);
        void Log(IEnumerable<string> messages);
    }
}
