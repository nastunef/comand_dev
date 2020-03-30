using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

        [Table("ADMIN.PERSONCARD_TRIP")]
        public partial class PERSONCARD_TRIP
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public PERSONCARD_TRIP()
            {
                PERSONCARD = new HashSet<PERSONCARD>();
            }

            [Key]
            public int PK_PERSONCARD_TRIP { get; set; }

            [StringLength(500)]
            public string GOAL { get; set; }

            [StringLength(500)]
            public string FINANCE { get; set; }

            public DateTime? STARTDATE { get; set; }

            public DateTime? ENDDATE { get; set; }


            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }

        }
    }
}
