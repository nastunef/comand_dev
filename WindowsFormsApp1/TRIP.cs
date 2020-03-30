namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TRIP")]
    public partial class TRIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIP()
        {
            PERSONCARD = new HashSet<PERSONCARD>();
            TRIP_ORG = new HashSet<TRIP_ORG>();
        }

        [Key]
        public decimal PK_TRIP { get; set; }

        [StringLength(500)]
        public string GOAL { get; set; }

        [StringLength(500)]
        public string FINANCE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public long PK_PRIKAZ { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP_ORG> TRIP_ORG { get; set; }
    }
}
