using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK.DESKTOP.MODEL.Helper
{
   public  class Data
    {
        public static tccEntities getContexto ()
        {
            tccEntities odb = new tccEntities();
            return odb;
        }
    }
}
