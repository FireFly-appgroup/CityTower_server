namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments_news
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Com_news_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int News_id { get; set; }

        public int Uid { get; set; }

        public DateTime Com_news_date { get; set; }

        [Required]
        [StringLength(3800)]
        public string Com_news_body { get; set; }

        public int? Com_news_like { get; set; }

        public int? Com_news_dislike { get; set; }

        public virtual News News { get; set; }
    }
}
