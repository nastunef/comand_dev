namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.LANGUAGE_LVL")]
    public partial class LANGUAGE_LVL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LANGUAGE_LVL()
        {
            UNION_LANGUAGE_PERSONCARD = new HashSet<UNION_LANGUAGE_PERSONCARD>();
        }

        [Key]
        public decimal PK_LANG_LVL { get; set; }

        [StringLength(255)]
        public string CIPHER { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNION_LANGUAGE_PERSONCARD> UNION_LANGUAGE_PERSONCARD { get; set; }
    }
}
