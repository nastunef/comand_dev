namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.SPECIALTY")]
    public partial class SPECIALTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPECIALTY()
        {
            ONE_EDU = new HashSet<ONE_EDU>();
        }

        [Key]
        public decimal PK_SPECIAL { get; set; }

        [StringLength(500)]
        public string CIPHER { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ONE_EDU> ONE_EDU { get; set; }
    }
}
