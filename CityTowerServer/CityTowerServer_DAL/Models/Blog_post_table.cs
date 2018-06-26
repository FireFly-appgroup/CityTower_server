namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_post_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog_post_table()
        {
            Blog_post_comments = new HashSet<Blog_post_comments>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blog_post_id { get; set; }

        [Required]
        [StringLength(200)]
        public string Blog_post_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string Blog_post_body { get; set; }

        public DateTime Blog_post_data { get; set; }

        public double? Blog_post_rating { get; set; }

        public int? Blog_post_like { get; set; }

        public int? Blog_post_dislike { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog_post_comments> Blog_post_comments { get; set; }
    }
}
