namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auctioneer")]
    public partial class Auctioneer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Auctioneer_id { get; set; }

        [Required]
        [StringLength(300)]
        public string Auctioneer_name { get; set; }

        [StringLength(400)]
        public string Auctioneer_comment { get; set; }

        public int Auctioneer_start_price { get; set; }

        [MaxLength(1)]
        public byte[] Auctioneer_direction { get; set; }

        public double? Auctioneer_price_step { get; set; }

        public int? Auctioneer_price { get; set; }

        public int? Auctioneer_price_uid { get; set; }

        public int? Auctioneer_ransom_price { get; set; }

        public DateTime Auctioneer_date { get; set; }

        public DateTime Auctioneer_end_date { get; set; }

        public int Uid { get; set; }

        public int City_id { get; set; }

        public int Country_id { get; set; }

        public int Auctioneer_category_id { get; set; }

        public virtual Users Users { get; set; }

        public virtual Auctioneer_category_list Auctioneer_category_list { get; set; }

        public virtual Country_list Country_list { get; set; }

        public virtual City_list City_list { get; set; }

        public virtual Auctioneer_history Auctioneer_history { get; set; }
    }
}
