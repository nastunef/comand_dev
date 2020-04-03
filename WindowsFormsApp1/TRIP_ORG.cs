namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TRIP_ORG")]
    public partial class TRIP_ORG
    {
        [Key]
        public decimal PK_TRIP_ORG { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        public decimal PK_PLACE_TRIP { get; set; }

        public virtual PLACE_TRIP PLACE_TRIP { get; set; }
    }
}
