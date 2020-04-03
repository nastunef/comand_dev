namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.STR_SHTAT_RASP")]
    public partial class STR_SHTAT_RASP
    {
        public decimal PK_PODRAZDEL { get; set; }

        [Key]
        public decimal PK_STROKA { get; set; }

        public decimal? COUNT_STUFF { get; set; }

        public decimal? TARIFF { get; set; }

        public decimal? NADBAVKA1 { get; set; }

        public long SHTAT_RASP_PK_SHTAT_RASP { get; set; }

        public decimal? NADBAVKA2 { get; set; }

        public decimal? NADBAVKA3 { get; set; }

        [StringLength(400)]
        public string NOTE { get; set; }

        public decimal PK_JOB_POS { get; set; }

        public virtual JOB_POSITION JOB_POSITION { get; set; }

        public virtual PODRAZDELORG PODRAZDELORG { get; set; }

        public virtual SHTAT_RASP SHTAT_RASP { get; set; }
    }
}
