using System.Data.Entity.Infrastructure.Design;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public class StringShtatRasp
    {
        public int stringId { get; set; }
        public string stringName { get; set; }
        public string stringKod { get; set; }
        public string stringDolgnost { get; set; }
        public string stringKolEd { get; set; }
        public double stringoklad { get; set; }
        public double stringNad1 { get; set; }
        public double stringNad2 { get; set; }
        public double stringNad3 { get; set; }
        
        public double stringTotal { get; set; }
        public string stringPrim { get; set; }

        public int PkPodrazdel { get; set; }
    }
}