namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poster")]
    public partial class Poster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poster()
        {
            Comments_poster = new HashSet<Comments_poster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Poster_id { get; set; }

        [Required]
        [StringLength(150)]
        public string Poster_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string Poster_body { get; set; }

        public DateTime Poster_date { get; set; }

        public DateTime Poster_start_date { get; set; }

        public double? Poster_rating { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int Poster_category_id { get; set; }

        public int? Poster_like { get; set; }

        public int? Poster_dislike { get; set; }

        public virtual City_list City_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_poster> Comments_poster { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual Users Users { get; set; }

        public virtual Poster_category_list Poster_category_list { get; set; }
    }
}
