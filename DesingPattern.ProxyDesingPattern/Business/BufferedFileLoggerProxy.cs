using DesingPattern.ProxyDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.ProxyDesingPattern.Business
{
    public class BufferedFileLoggerProxy : ILogger
    {
        private readonly FileLogger fileLogger;
        private readonly int bufferSize;
        private List<string> buffer;


        public BufferedFileLoggerProxy(int bufferSize)
        {
            this.bufferSize = bufferSize;
            fileLogger=new FileLogger(); 
            buffer=new List<string>();
        }


        public void Log(string message)
        {
            if(bufferSize<buffer.Count)
            {
                //foreach(var log in buffer) 
                //{ 
                //    fileLogger.Log(log);
                //}
                fileLogger.Log(buffer);
                buffer.Clear();
            }
        }

        public void Log(IEnumerable<string> messages)
        {
            fileLogger.Log(messages);
        }
    }
}
