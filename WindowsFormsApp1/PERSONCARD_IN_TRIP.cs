namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PERSONCARD_IN_TRIP")]
    public partial class PERSONCARD_IN_TRIP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PK { get; set; }

        [StringLength(500)]
        public string GOAL { get; set; }

        [StringLength(500)]
        public string FINANCE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public long? PK_TRIP { get; set; }

        public decimal PK_PERSONCARD { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual UPDTRIP UPDTRIP { get; set; }
    }
}
