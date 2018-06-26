namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tag_list
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tag_id { get; set; }

        [Required]
        [StringLength(200)]
        public string Tag_name { get; set; }

        public int? Announcement_count { get; set; }

        public int? Comments_announcement_count { get; set; }

        public int? Auctioneer_count { get; set; }

        public int? News_count { get; set; }

        public int? Comments_news_count { get; set; }

        public int? Places_count { get; set; }

        public int? Comments_places_count { get; set; }

        public int? Poster_count { get; set; }

        public int? Comments_poster_count { get; set; }

        public int? Blog_post_count { get; set; }

        public int? Blog_post_comments_count { get; set; }

        public int? Chat_count { get; set; }

        public int? User_use_count { get; set; }

        public int? User_count { get; set; }

        public int? Goods_count { get; set; }

        public virtual Announcement_tag Announcement_tag { get; set; }

        public virtual Auctioneer_tag Auctioneer_tag { get; set; }

        public virtual Blog_post_comments_tag Blog_post_comments_tag { get; set; }

        public virtual Blog_post_tag Blog_post_tag { get; set; }

        public virtual Chat_tag Chat_tag { get; set; }

        public virtual Comments_announcement_tag Comments_announcement_tag { get; set; }

        public virtual Comments_news_tag Comments_news_tag { get; set; }

        public virtual Comments_places_tag Comments_places_tag { get; set; }

        public virtual Comments_poster_tag Comments_poster_tag { get; set; }

        public virtual Goods_tag Goods_tag { get; set; }

        public virtual News_tag News_tag { get; set; }

        public virtual Places_tag Places_tag { get; set; }

        public virtual Poster_tag Poster_tag { get; set; }

        public virtual User_tag User_tag { get; set; }

        public virtual User_use_tag User_use_tag { get; set; }
    }
}
