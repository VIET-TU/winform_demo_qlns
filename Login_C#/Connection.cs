using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_C_
{
    internal  class Connection
    {
        public static QLNSEntities db;
        public Connection() { 
            db = new QLNSEntities();
        }
    }
}
