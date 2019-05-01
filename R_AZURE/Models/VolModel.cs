using System;
namespace R_AZURE.Models
{
    public class VolModel
    {
        public String numVol {get; set;}
        public String depart { get; set; }
        public String arriver { get; set; }
        public DateTime heureDepart { get; set; }
        public DateTime heureArriver { get; set; }
        public int place { get; set; }


        //public VolMode();
        public VolModel(String num, String d, String a,DateTime timeD, DateTime timeA, int p )
        {
            this.numVol = num;
            this.depart = d;
            this.arriver = a;
            this.heureDepart = timeD;
            this.heureArriver = timeA;
            this.place = p;

        }

        public VolModel(String num,String d, String a)
        {
            this.numVol = num;
            this.depart = d;
            this.arriver = a;
        }
    }
}
