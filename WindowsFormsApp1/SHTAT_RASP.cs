namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.SHTAT_RASP")]
    public partial class SHTAT_RASP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHTAT_RASP()
        {
            STR_SHTAT_RASP = new HashSet<STR_SHTAT_RASP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PK_SHTAT_RASP { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(255)]
        public string number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STR_SHTAT_RASP> STR_SHTAT_RASP { get; set; }
    }
}
