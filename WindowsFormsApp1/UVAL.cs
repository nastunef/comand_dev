namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.UVAL")]
    public partial class UVAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PK_UVAL { get; set; }

        [StringLength(500)]
        public string REASOM { get; set; }

        public DateTime? ENDWORKDOGOVORDATE { get; set; }

        public DateTime? UVALDATE { get; set; }

        [StringLength(100)]
        public string NUMWORKDOGOVOR { get; set; }

        public long? PK_PODRAZDEL { get; set; }

        public decimal PK_JOB_POS { get; set; }

        public decimal? PK_PERSONCARD { get; set; }

        public long PK_PRIKAZ { get; set; }

        public virtual JOB_POSITION JOB_POSITION { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }
    }
}
