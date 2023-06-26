using DesingPattern.ProxyDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.ProxyDesingPattern.Business
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            message = $"{DateTime.Now:dd.MM.yyyy} - {message}";
            File.AppendAllText("message.log", message);
        }
        public void Log(IEnumerable<string> messages)
        {
            //Şöylede bir şey yapılabilirdi Bulk ı desteklemiyorum gibisinden
            //throw new NotImplementedException();
            File.AppendAllText("message.log", string.Join(Environment.NewLine, messages));
        }
    }
}
