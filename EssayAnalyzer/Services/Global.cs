using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Global
    {
        public static ServerInterface ServerInterface
        {
            get
            {
                if (_serverInterface == null)
                    _serverInterface = new ServerInterface();
                return _serverInterface;
            }
        }
        private static ServerInterface _serverInterface;
    }
}
