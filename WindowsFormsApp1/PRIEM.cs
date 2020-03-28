namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PRIEM")]
    public partial class PRIEM
    {
        [StringLength(1000)]
        public string REASON { get; set; }

        public DateTime? STARTWORKDATE { get; set; }

        public DateTime? ENDWORKDATE { get; set; }

        public decimal PK_PODR { get; set; }

        public decimal? PK_PERSONCARD { get; set; }

        public decimal? TESTPERIOD { get; set; }

        public long? PK_PRIKAZ { get; set; }

        [StringLength(200)]
        public string CONDITIONS { get; set; }

        public decimal PK_JOB_POS { get; set; }

        [Key]
        public decimal PK_PRIEM { get; set; }

        public decimal PK_CHAR_WORK { get; set; }

        public decimal PODRAZDELORG_PK_PODRAZDEL { get; set; }

        public virtual CHARACTER_WORK CHARACTER_WORK { get; set; }

        public virtual JOB_POSITION JOB_POSITION { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }
    }
}
