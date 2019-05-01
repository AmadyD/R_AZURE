using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R_AZURE.Controllers
{
    public class MvcVolsModel
    {

        public int id_vol { get; set; }
        public string nom_vol { get; set; }
        public string aero_depart { get; set; }
        public string aero_arriv { get; set; }
        public Nullable<System.DateTime> date_depart { get; set; }
        public Nullable<System.DateTime> date_arriv { get; set; }

    }
}
