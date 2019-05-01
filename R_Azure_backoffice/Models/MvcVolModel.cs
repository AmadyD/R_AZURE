using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace R_Azure_backoffice.Models
{
    public class MvcVolModel
    {

        public int id_vol { get; set; }

        [Required(ErrorMessage ="Ce champs est obligatoire")]
        public string nom_vol { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string aero_depart { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string aero_arriv { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public Nullable<System.DateTime> date_depart { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public Nullable<System.DateTime> date_arriv { get; set; }
    }
}
