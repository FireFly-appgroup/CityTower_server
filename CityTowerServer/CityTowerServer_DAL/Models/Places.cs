namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Places
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Places()
        {
            Comments_places = new HashSet<Comments_places>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Places_id { get; set; }

        [Required]
        [StringLength(150)]
        public string Places_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string Places_body { get; set; }

        public DateTime Places_date { get; set; }

        public DateTime Places_start_date { get; set; }

        public double? Places_rating { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int Places_category_id { get; set; }

        public int? Places_like { get; set; }

        public int? Places_dislike { get; set; }

        public virtual City_list City_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_places> Comments_places { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual Users Users { get; set; }

        public virtual Places_category_list Places_category_list { get; set; }
    }
}
