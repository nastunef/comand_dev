namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.JOB_POSITION")]
    public partial class JOB_POSITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JOB_POSITION()
        {
            PEREVOD = new HashSet<PEREVOD>();
            PEREVOD1 = new HashSet<PEREVOD>();
            PERSONCARD = new HashSet<PERSONCARD>();
            PRIEM = new HashSet<PRIEM>();
            STR_SHTAT_RASP = new HashSet<STR_SHTAT_RASP>();
            UVAL = new HashSet<UVAL>();
        }

        [Key]
        public decimal PK_JOB_POS { get; set; }

        [StringLength(255)]
        public string CIPHER { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIEM> PRIEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STR_SHTAT_RASP> STR_SHTAT_RASP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UVAL> UVAL { get; set; }
    }
}
