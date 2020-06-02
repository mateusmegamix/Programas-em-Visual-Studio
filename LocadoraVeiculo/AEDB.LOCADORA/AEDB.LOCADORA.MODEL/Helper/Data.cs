using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEDB.LOCADORA.MODEL.Helper
{
    public class Data
    {
        public static danielgomesEntities getContexto()
        {
            danielgomesEntities odb = new danielgomesEntities();
            odb.Configuration.ProxyCreationEnabled = false; 
            return odb;
        }
    }
}
