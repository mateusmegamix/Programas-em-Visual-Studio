using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaQuiminvest.Model.Helper
{
    public class Data
    {
        public static reatorEntities getContexto()
        {
            reatorEntities odb = new reatorEntities();
            return odb;
        }
    }
}