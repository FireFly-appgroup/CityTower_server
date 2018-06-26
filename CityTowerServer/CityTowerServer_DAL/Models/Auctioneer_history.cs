namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Auctioneer_history
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Auctioneer_id { get; set; }

        public DateTime Auc_history_date_time { get; set; }

        [Required]
        [StringLength(250)]
        public string Auc_history_action { get; set; }

        public int Uid { get; set; }

        public virtual Auctioneer Auctioneer { get; set; }
    }
}
