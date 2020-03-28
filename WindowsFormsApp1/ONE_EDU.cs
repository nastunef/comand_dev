namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.ONE_EDU")]
    public partial class ONE_EDU
    {
        [Key]
        [Column(Order = 0)]
        public decimal PK_PERSONCARD { get; set; }

        [StringLength(255)]
        public string NUMDOC { get; set; }

        public DateTime? ENDDATE { get; set; }

        public decimal PK_TYPE_EDU { get; set; }

        public decimal PK_PLACE_EDU { get; set; }

        public decimal PK_SPECIAL { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal PK_ONE_EDU { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual PLACE_EDU PLACE_EDU { get; set; }

        public virtual SPECIALTY SPECIALTY { get; set; }

        public virtual TYPE_EDU TYPE_EDU { get; set; }
    }
}
