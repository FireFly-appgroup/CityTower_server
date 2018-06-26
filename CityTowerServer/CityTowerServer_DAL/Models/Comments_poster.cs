namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments_poster
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Com_poster_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Poster_id { get; set; }

        public int Uid { get; set; }

        public DateTime Com_poster_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string Com_poster_body { get; set; }

        public int? Com_poster_like { get; set; }

        public int? Com_poster_dislike { get; set; }

        public virtual Poster Poster { get; set; }
    }
}
