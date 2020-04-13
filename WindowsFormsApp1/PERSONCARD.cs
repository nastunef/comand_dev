namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PERSONCARD")]
    public partial class PERSONCARD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONCARD()
        {
            FAMILY_MEMBER = new HashSet<FAMILY_MEMBER>();
            ONE_EDU = new HashSet<ONE_EDU>();
            PEREVOD = new HashSet<PEREVOD>();
            PERSONCARD_IN_TRIP = new HashSet<PERSONCARD_IN_TRIP>();
            STR_TABEL = new HashSet<STR_TABEL>();
            UNION_LANGUAGE_PERSONCARD = new HashSet<UNION_LANGUAGE_PERSONCARD>();
            UVAL = new HashSet<UVAL>();
            PRIKAZ = new HashSet<PRIKAZ>();   
        }

        [Key]
        public decimal PK_PERSONCARD { get; set; }

        [StringLength(200)]
        public string SURNAME { get; set; }

        [StringLength(200)]
        public string NAME { get; set; }

        [StringLength(200)]
        public string MIDDLENAME { get; set; }

        [StringLength(200)]
        public string MOBTEL { get; set; }

        [StringLength(200)]
        public string DOPTEL { get; set; }

        public decimal PK_OUR_ORG { get; set; }

        [StringLength(4)]
        public string SERPASSPORT { get; set; }

        [StringLength(6)]
        public string NUMPASSPORT { get; set; }
        public DateTime? PASSPORTGETDATE { get; set; }

        [StringLength(500)]
        public string PLACELIVE { get; set; }

        [StringLength(1000)]
        public string PLACEREGISTER { get; set; }

        [StringLength(1000)]
        public string PLACEBIRTH { get; set; }

        public DateTime? UVALDATE { get; set; }

        [StringLength(500)]
        public string REASON_UVAL { get; set; }

        [StringLength(500)]
        public string DOPINFO { get; set; }

        public DateTime? DATECREATE { get; set; }

        public decimal? TABEL_NUM { get; set; }

        [StringLength(3)]
        public string ALPHABET { get; set; }

        [StringLength(25)]
        public string INN { get; set; }

        [StringLength(25)]
        public string SNILS { get; set; }

        public DateTime? BIRTHDATE { get; set; }

        public decimal? PK_TABEL { get; set; }

        public decimal PK_MARTIAL_STATUS { get; set; }

        public decimal PK_GENDER { get; set; }

        public decimal? PK_TYPE_WORK { get; set; }

        public decimal? PK_CHAR_WORK { get; set; }

        public decimal? PK_PROF { get; set; }

        public decimal? PK_GRAZD { get; set; }

        public decimal? JOB_POSITION_PK_JOB_POS { get; set; }

        [StringLength(300)]
        public string PLACE_VIDACHI_PASSPORT { get; set; }

        public virtual CHARACTER_WORK CHARACTER_WORK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FAMILY_MEMBER> FAMILY_MEMBER { get; set; }

        public virtual GENDER GENDER { get; set; }

        public virtual GRAZDAN GRAZDAN { get; set; }

        public virtual JOB_POSITION JOB_POSITION { get; set; }

        public virtual MARTIAL_STATUS MARTIAL_STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ONE_EDU> ONE_EDU { get; set; }

        public virtual OUR_ORG OUR_ORG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEREVOD> PEREVOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONCARD_IN_TRIP> PERSONCARD_IN_TRIP { get; set; }

        public virtual PROFESSION PROFESSION { get; set; }

        public virtual TABEL TABEL { get; set; }

        public virtual TYPE_WORK TYPE_WORK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STR_TABEL> STR_TABEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNION_LANGUAGE_PERSONCARD> UNION_LANGUAGE_PERSONCARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UVAL> UVAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRIKAZ> PRIKAZ { get; set; }
    }
}
