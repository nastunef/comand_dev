namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.STR_TABEL")]
    public partial class STR_TABEL
    {
        [Key]
        public decimal PK_STR_TABEL { get; set; }

        [StringLength(2)]
        public string DAY1 { get; set; }

        [StringLength(2)]
        public string DAY2 { get; set; }

        [StringLength(2)]
        public string DAY3 { get; set; }

        [StringLength(2)]
        public string DAY4 { get; set; }

        [StringLength(2)]
        public string DAY5 { get; set; }

        [StringLength(2)]
        public string DAY6 { get; set; }

        public decimal PK_TABEL { get; set; }

        [StringLength(2)]
        public string DAY7 { get; set; }

        [StringLength(2)]
        public string DAY8 { get; set; }

        [StringLength(2)]
        public string DAY9 { get; set; }

        [StringLength(2)]
        public string DAY10 { get; set; }

        [StringLength(2)]
        public string DAY11 { get; set; }

        [StringLength(2)]
        public string DAY12 { get; set; }

        [StringLength(2)]
        public string DAY13 { get; set; }

        [StringLength(2)]
        public string DAY14 { get; set; }

        [StringLength(2)]
        public string DAY15 { get; set; }

        [StringLength(2)]
        public string DAY16 { get; set; }

        [StringLength(2)]
        public string DAY17 { get; set; }

        [StringLength(2)]
        public string DAY18 { get; set; }

        [StringLength(2)]
        public string DAY19 { get; set; }

        [StringLength(2)]
        public string DAY20 { get; set; }

        [StringLength(2)]
        public string DAY21 { get; set; }

        [StringLength(2)]
        public string DAY22 { get; set; }

        [StringLength(2)]
        public string DAY23 { get; set; }

        [StringLength(2)]
        public string DAY24 { get; set; }

        [StringLength(2)]
        public string DAY25 { get; set; }

        [StringLength(2)]
        public string DAY26 { get; set; }

        [StringLength(2)]
        public string DAY27 { get; set; }

        [StringLength(2)]
        public string DAY28 { get; set; }

        [StringLength(2)]
        public string DAY29 { get; set; }

        [StringLength(2)]
        public string DAY30 { get; set; }

        [StringLength(2)]
        public string DAY31 { get; set; }

        public virtual TABEL TABEL { get; set; }
    }
}
