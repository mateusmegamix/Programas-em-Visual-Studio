using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOP.MODEL;

namespace SICOP.CONTROLLER
{
    public class CDatabase
    {
        public static void CriarBanco()
        {
            Database db = new Database();
            db.CriarBanco();
        }
    }
}
