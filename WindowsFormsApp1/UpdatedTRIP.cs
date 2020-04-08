using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Table("ADMIN.UPDTRIP")]
    public partial class UpdatedTRIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UpdatedTRIP()
        {
            PERSONCARD_IN_TRIP = new HashSet<PERSONCARD_IN_TRIP>();
            TRIP_ORG = new HashSet<TRIP_ORG>();
        }

        [Key]
        [Column("PK_TRIP")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PK_TRIP { get; set; }

        [StringLength(500)]
        public string OSNOVANIE { get; set; }

        [StringLength(1500)]
        public string NOTE { get; set; }

        [Column("OSNOVANIEDATE")]
        public DateTime? OSNOVANIEDATE { get; set; }

        public long? PK_PRIKAZ { get; set; }

        [ForeignKey("PK_PRIKAZ")]
        public virtual PRIKAZ PRIKAZ { get; set; }

        public virtual ICollection<PERSONCARD_IN_TRIP> PERSONCARD_IN_TRIP { get; set; }

        public virtual ICollection<TRIP_ORG> TRIP_ORG { get; set; }
    }
}

