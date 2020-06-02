using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManutencaoQuiminvest.Model.Helper
{
    public class Data
    {
        public static ManutencaoEntities getContexto()
        {
            ManutencaoEntities odb = new ManutencaoEntities();
            return odb;
        }
    }
}
