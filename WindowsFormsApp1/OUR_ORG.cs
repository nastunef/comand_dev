namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.OUR_ORG")]
    public partial class OUR_ORG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OUR_ORG()
        {
            PERSONCARD = new HashSet<PERSONCARD>();
            PRIKAZ = new HashSet<PRIKAZ>();
        }

        [Key]
        public decimal PK_OUR_ORG { get; set; }

        [StringLength(500)]
        public string NAME { get; set; }

        [StringLength(255)]
        public string INN { get; set; }

        [StringLength(500)]
        public string PAYMENTACC { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(35)]
        public string OGRN { get; set; }

        [StringLength(15)]
        public string OKPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD> PERSONCARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIKAZ> PRIKAZ { get; set; }
    }
}
