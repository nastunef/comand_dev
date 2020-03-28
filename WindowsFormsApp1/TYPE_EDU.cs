namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TYPE_EDU")]
    public partial class TYPE_EDU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_EDU()
        {
            ONE_EDU = new HashSet<ONE_EDU>();
        }

        [Key]
        public decimal PK_TYPE_EDU { get; set; }

        [StringLength(255)]
        public string CIPHER { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ONE_EDU> ONE_EDU { get; set; }
    }
}
