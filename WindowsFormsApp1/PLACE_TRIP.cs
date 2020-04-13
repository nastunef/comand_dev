namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMIN.PLACE_TRIP")]
    public partial class PLACE_TRIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLACE_TRIP()
        {
            TRIP_ORG = new HashSet<TRIP_ORG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PK_PLACE_TRIP { get; set; }

        [StringLength(1000)]
        public string NAME { get; set; }
        
        [NotMapped]
        private string country;
        [NotMapped]
        public string Country {
            get
            {
                return NAME.Substring(0, NAME.IndexOf(','));
            }
            set
            {
                country = value;
            }
        }

        [NotMapped]
        private string city;
        [NotMapped]
        public string City
        {
            get
            {
                return NAME.Substring(NAME.IndexOf(',')+1).Replace(" ", "");
            }
            set
            {
                city = value;    
            }

        }

        public void createName()
        {
            NAME = country + ", " + city;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP_ORG> TRIP_ORG { get; set; }
    }
}
