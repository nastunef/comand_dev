namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.TRIP_ORG")]
    public partial class TRIP_ORG
    {
        public TRIP_ORG()
        {
            TRIP = new HashSet<TRIP>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PK_TRIP_ORG { get; set; }

        [StringLength(255)]
        public string NAME { get; set; }

        public decimal PK_PLACE_TRIP { get; set; }

        public virtual PLACE_TRIP PLACE_TRIP { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP> TRIP { get; set; }

        public new virtual string ToString => NAME;
    }
}
