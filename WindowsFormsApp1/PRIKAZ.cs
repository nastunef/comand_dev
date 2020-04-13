namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PRIKAZ")]
    public partial class PRIKAZ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRIKAZ()
        {
            PEREVOD = new HashSet<PEREVOD>();
            PRIEM = new HashSet<PRIEM>();
            UPDTRIP = new HashSet<UPDTRIP>();
            UVAL = new HashSet<UVAL>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PK_PRIKAZ { get; set; }

        [StringLength(100)]
        public string OKUD { get; set; }

        [StringLength(100)]
        public string OKPO { get; set; }

        [StringLength(200)]
        public string NUMDOC { get; set; }

        [StringLength(300)]
        public string PATH { get; set; }

        public decimal? PK_OUR_ORG { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(1)]
        public string ISPROJECT { get; set; }

        public decimal? PK_TYPE_PRIKAZ { get; set; }

        public decimal? PK_PERSONCARD { get; set; }

        public virtual OUR_ORG OUR_ORG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIEM> PRIEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UPDTRIP> UPDTRIP { get; set; }

        public virtual TYPE_PRIKAZ TYPE_PRIKAZ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UVAL> UVAL { get; set; }
        
        public virtual PERSONCARD PERSONCARD { get; set; }
    }
}
