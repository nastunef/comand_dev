namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.UNION_LANGUAGE_PERSONCARD")]
    public partial class UNION_LANGUAGE_PERSONCARD
    {
        [Key]
        public decimal PK_UNION { get; set; }

        public decimal PK_LANGUAGE { get; set; }

        public decimal PK_LANGUAGE_LVL { get; set; }

        public decimal PK_PERSONCARD { get; set; }

        public virtual LANGUAGE LANGUAGE { get; set; }

        public virtual LANGUAGE_LVL LANGUAGE_LVL { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }
    }
}
