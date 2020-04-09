namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.UPDTRIP")]
    public partial class UPDTRIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UPDTRIP()
        {
            PERSONCARD_IN_TRIP = new HashSet<PERSONCARD_IN_TRIP>();
            TRIP_ORG = new HashSet<TRIP_ORG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PK_TRIP { get; set; }

        [StringLength(500)]
        public string OSNOVANIE { get; set; }

        public DateTime? OSNOVANIEDATE { get; set; }

        public long? PK_PRIKAZ { get; set; }

        [StringLength(1500)]
        public string NOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD_IN_TRIP> PERSONCARD_IN_TRIP { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP_ORG> TRIP_ORG { get; set; }
    }
}
