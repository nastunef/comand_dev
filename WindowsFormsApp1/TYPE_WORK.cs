namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TYPE_WORK")]
    public partial class TYPE_WORK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_WORK()
        {
            PERSONCARD = new HashSet<PERSONCARD>();
        }

        [Key]
        public decimal PK_TYPE_WORK { get; set; }

        [Required]
        [StringLength(255)]
        public string PK_WORK { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }
    }
}
