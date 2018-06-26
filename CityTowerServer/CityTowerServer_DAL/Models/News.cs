namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            Comments_news = new HashSet<Comments_news>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int News_id { get; set; }

        [Required]
        [StringLength(150)]
        public string News_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string News_body { get; set; }

        public DateTime News_date { get; set; }

        public double? News_rating { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int News_category_id { get; set; }

        public int? News_like { get; set; }

        public int? News_dislike { get; set; }

        public virtual City_list City_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_news> Comments_news { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual Users Users { get; set; }

        public virtual News_category_list News_category_list { get; set; }
    }
}
