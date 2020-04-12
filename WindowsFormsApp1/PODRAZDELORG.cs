namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PODRAZDELORG")]
    public partial class PODRAZDELORG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PODRAZDELORG()
        {
            PEREVOD = new HashSet<PEREVOD>();
            PEREVOD1 = new HashSet<PEREVOD>();
            PODRAZDELORG1 = new HashSet<PODRAZDELORG>();
            PRIEM = new HashSet<PRIEM>();
            STR_SHTAT_RASP = new HashSet<STR_SHTAT_RASP>();
            TABEL = new HashSet<TABEL>();
            UVAL = new HashSet<UVAL>();
        }

        [Key]
        public decimal PK_PODRAZDEL { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string CODE { get; set; }

        public DateTime? DATECREATE { get; set; }

        public decimal? PK_PODRAZDEL_PK_PODRAZDEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PODRAZDELORG> PODRAZDELORG1 { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIEM> PRIEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STR_SHTAT_RASP> STR_SHTAT_RASP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABEL> TABEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UVAL> UVAL { get; set; }
    }
}
