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
            PLACE_TRIP = new HashSet<PLACE_TRIP>();
        }

        [Key]
        public decimal PK_TRIP { get; set; }

        [StringLength(500)]
        public string GOAL { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public long PK_PRIKAZ { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLACE_TRIP> PLACE_TRIP { get; set; }
    }
}
