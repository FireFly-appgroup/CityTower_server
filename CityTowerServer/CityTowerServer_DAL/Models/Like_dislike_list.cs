namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Like_dislike_list
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Like_dislike_id { get; set; }

        public int? Like_dislike_comments_announcement_id { get; set; }

        public int? Like_dislike_auctioneer_id { get; set; }

        public int? Like_dislike_news_id { get; set; }

        public int? Like_dislike_comments_news_id { get; set; }

        public int? Like_dislike_places_id { get; set; }

        public int? Like_dislike_comments_places_id { get; set; }

        public int? Like_dislike_poster_id { get; set; }

        public int? Like_dislike_comments_poster_id { get; set; }

        public int? Like_dislike_blog_post_id { get; set; }

        public int? Like_dislike_blog_post_comments_id { get; set; }

        public int? Like_dislike_chat_id { get; set; }

        public int? Like_dislike_user_use_id { get; set; }

        public int? Like_dislike_user_id { get; set; }

        public int? Like_dislike_goods_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Uid { get; set; }

        public int? Like_dislike_announcement_id { get; set; }

        public virtual Users Users { get; set; }
    }
}
