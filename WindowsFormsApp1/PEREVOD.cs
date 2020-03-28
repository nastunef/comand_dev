namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PEREVOD")]
    public partial class PEREVOD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PK_PEREVOD { get; set; }

        public DateTime? STARTWORKDATE { get; set; }

        public DateTime? ENDWORKDATE { get; set; }

        [StringLength(100)]
        public string TYPE { get; set; }

        [StringLength(300)]
        public string REASON { get; set; }

        public decimal PK_PERSONCARD { get; set; }

        public decimal OLD_PODRAZDEL { get; set; }

        public decimal PK_OLD_JOB_POS { get; set; }

        public long PK_PRIKAZ { get; set; }

        public decimal PK_NEW_JOB_POS { get; set; }

        public decimal PK_NEW_PODRAZDEL { get; set; }

        public virtual JOB_POSITION JOB_POSITION { get; set; }

        public virtual JOB_POSITION JOB_POSITION1 { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG1 { get; set; }

        public virtual PRIKAZ PRIKAZ { get; set; }
    }
}
