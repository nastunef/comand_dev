namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PERSONCARD_IN_TRIP")]
    public partial class PERSONCARD_IN_TRIP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK { get; set; }

        [StringLength(500)]
        public string GOAL { get; set; }

        [StringLength(500)]
        public string FINANCE { get; set; }

        public DateTime? STARTDATE { get; set; }

        public DateTime? ENDDATE { get; set; }

        public long? PK_TRIP { get; set; }

        public decimal PK_PERSONCARD { get; set; }

        public virtual PERSONCARD PERSONCARD { get; set; }

        public virtual UPDTRIP UPDTRIP { get; set; }
        
        /**
         *
         * Для вывода в таблицу
         * 
         */
        [NotMapped]
        public String SURNAME => (PERSONCARD == null) ? null : PERSONCARD.SURNAME;

        [NotMapped]
        public String NAME => (PERSONCARD == null) ? null : PERSONCARD.NAME;

        [NotMapped] 
        public String MIDDLENAME => (PERSONCARD == null) ? null : PERSONCARD.MIDDLENAME;

        [NotMapped]
        public decimal? TABEL_NUM => (PERSONCARD == null) ? null : PERSONCARD.TABEL_NUM;


        [NotMapped]
        public JOB_POSITION JOB_POS => (PERSONCARD == null) ? null : PERSONCARD.JOB_POSITION;

        [NotMapped]
        public PODRAZDELORG PODRAZDELORG => (PERSONCARD == null || PERSONCARD.TABEL == null || PERSONCARD.TABEL.PODRAZDELORG == null) ? null : PERSONCARD.TABEL.PODRAZDELORG;
    }
}
