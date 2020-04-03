namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.FAMILY_MEMBER")]
    public partial class FAMILY_MEMBER
    {
        [Key]
        public decimal PK_MEMBER_FAMILY { get; set; }

        public DateTime? BIRTHYEAR { get; set; }

        public decimal PK_PERSONCARD { get; set; }

        [StringLength(500)]
        public string SURNAME { get; set; }

        [StringLength(300)]
        public string NAME { get; set; }

        [StringLength(500)]
        public string MIDDLENAME { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }
    }
}
