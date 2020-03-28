namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.GENDER")]
    public partial class GENDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENDER()
        {
            PERSONCARD = new HashSet<PERSONCARD>();
        }

        [Key]
        public decimal PK_GENDER { get; set; }

        [StringLength(255)]
        public string CIPHER { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }
    }
}
