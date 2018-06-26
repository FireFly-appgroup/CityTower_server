namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Announcement")]
    public partial class Announcement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Announcement()
        {
            Comments_announcement = new HashSet<Comments_announcement>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Announcement_id { get; set; }

        [Required]
        [StringLength(150)]
        public string Announcement_tema { get; set; }

        [Required]
        [StringLength(3800)]
        public string Announcement_body { get; set; }

        public DateTime Announcement_date { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int Announcement_category_id { get; set; }

        public int? Announcement_like { get; set; }

        public int? Announcement_dislike { get; set; }

        public int? Announcement_rating { get; set; }

        public virtual Users Users { get; set; }

        public virtual Announcement_category_list Announcement_category_list { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual City_list City_list { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments_announcement> Comments_announcement { get; set; }
    }
}
