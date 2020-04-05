namespace WindowsFormsApp1
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TRIP_ORG")]
    public partial class TRIP_ORG
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PK_TRIP_ORG")]
        public decimal PK_TRIP_ORG { get; set; }

        [StringLength(255)]
        [Column("NAME")]
        public string NAME { get; set; }

        [Column("PK_PLACE_TRIP")]
        public decimal PK_PLACE_TRIP { get; set; }

        [ForeignKey("PK_PLACE_TRIP")]
        public virtual PLACE_TRIP PLACE_TRIP { get; set; }

        public TRIP_ORG()
        {
            TRIP = new HashSet<UpdatedTRIP>();
        }

        //Костылёк
        [NotMapped]
        public string CountryPlace
        {
            get
            {
                return PLACE_TRIP.Country;
            }

            set
            {
                PLACE_TRIP.Country = value;
            }
        }

        [NotMapped]
        public string CityPlace
        {
            get
            {
                return PLACE_TRIP.City;
            }

            set
            {
                PLACE_TRIP.City = value;
            }
        }

        public virtual ICollection<UpdatedTRIP> TRIP { get; set; }

        public new virtual string ToString => NAME;
    }
}
