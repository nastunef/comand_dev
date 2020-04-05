using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Table("ADMIN.PERSONCARD_IN_TRIP")]
    public partial class PERSONCARD_IN_TRIP
    {
        [Key]
        [Column("PK")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PK { get; set; }

        [StringLength(500)]
        public string GOAL { get; set; }

        [StringLength(500)]
        public string FINANCE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }
        [Column("PK_TRIP")]
        public decimal PK_TRIP { get; set; }
        [ForeignKey("PK_TRIP")]
        public UpdatedTRIP TRIP { get; set; } 

        [Column("PK_PERSONCARD")]
        public decimal PK_PERSONCARD { get; set; }
        [ForeignKey("PK_PERSONCARD")]
        public virtual PERSONCARD PERSONCARD { get; set; }

        [NotMapped]
        public String SURNAME 
        { 
            get
            {
                if (PERSONCARD == null) return null;
                return PERSONCARD.SURNAME;
            } 
        }


        [NotMapped]
        public String NAME
        {
            get
            {
                if (PERSONCARD == null) return null;
                return PERSONCARD.NAME;
            }
        }
        [NotMapped]
        public String MIDDLENAME
        {
            get
            {
                if (PERSONCARD == null) return null;
                return PERSONCARD.MIDDLENAME;
            }
        }

        [NotMapped]
        public decimal? TABEL_NUM
        {
            get
            {
                if (PERSONCARD == null) return null;
                return PERSONCARD.TABEL_NUM;
            }
        }


        [NotMapped]
        public JOB_POSITION JOB_POS
        {
            get
            {
                if (PERSONCARD == null) return null;
                return PERSONCARD.JOB_POSITION;
            }
        }
    }
    
}
