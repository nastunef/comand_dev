namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PLACE_TRIP")]
    public partial class PLACE_TRIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLACE_TRIP()
        {
            TRIP_ORG = new HashSet<TRIP_ORG>();
        }

        [Key]
        public decimal PK_PLACE_TRIP { get; set; }

        [StringLength(1000)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP_ORG> TRIP_ORG { get; set; }
    }
}
