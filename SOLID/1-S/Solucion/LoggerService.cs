using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S.Solucion
{
    public interface ILoggerService
    {
        //Necesito que esta logging suceda por esa raz{on cargo todo los elemeentos
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class LoggerService : ILoggerService
    {

        public LoggerService() 
        {
            //codigo se se utilizara al iniciar la casles

        }
        public void Debug(string info)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string info)
        {
            //escribir informacion en un log
            throw new NotImplementedException();
        }

      
    }
}
