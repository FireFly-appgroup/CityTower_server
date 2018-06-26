namespace CityTowerServer_DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CityTowerDataBase : DbContext
    {
        public CityTowerDataBase()
            : base("name=CityTowerDataBase")
        {
        }

        public virtual DbSet<All_chat> All_chat { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<Announcement_category_list> Announcement_category_list { get; set; }
        public virtual DbSet<Announcement_tag> Announcement_tag { get; set; }
        public virtual DbSet<Auctioneer> Auctioneer { get; set; }
        public virtual DbSet<Auctioneer_category_list> Auctioneer_category_list { get; set; }
        public virtual DbSet<Auctioneer_history> Auctioneer_history { get; set; }
        public virtual DbSet<Auctioneer_tag> Auctioneer_tag { get; set; }
        public virtual DbSet<Blog_category_list> Blog_category_list { get; set; }
        public virtual DbSet<Blog_list> Blog_list { get; set; }
        public virtual DbSet<Blog_post_comments> Blog_post_comments { get; set; }
        public virtual DbSet<Blog_post_comments_tag> Blog_post_comments_tag { get; set; }
        public virtual DbSet<Blog_post_table> Blog_post_table { get; set; }
        public virtual DbSet<Blog_post_tag> Blog_post_tag { get; set; }
        public virtual DbSet<Blog_status_list> Blog_status_list { get; set; }
        public virtual DbSet<Blog_user_table> Blog_user_table { get; set; }
        public virtual DbSet<Chat_tag> Chat_tag { get; set; }
        public virtual DbSet<City_list> City_list { get; set; }
        public virtual DbSet<Comments_announcement> Comments_announcement { get; set; }
        public virtual DbSet<Comments_announcement_tag> Comments_announcement_tag { get; set; }
        public virtual DbSet<Comments_eshop> Comments_eshop { get; set; }
        public virtual DbSet<Comments_news> Comments_news { get; set; }
        public virtual DbSet<Comments_news_tag> Comments_news_tag { get; set; }
        public virtual DbSet<Comments_places> Comments_places { get; set; }
        public virtual DbSet<Comments_places_tag> Comments_places_tag { get; set; }
        public virtual DbSet<Comments_poster> Comments_poster { get; set; }
        public virtual DbSet<Comments_poster_tag> Comments_poster_tag { get; set; }
        public virtual DbSet<Country_list> Country_list { get; set; }
        public virtual DbSet<Goods_category_list> Goods_category_list { get; set; }
        public virtual DbSet<Goods_photo_id> Goods_photo_id { get; set; }
        public virtual DbSet<Goods_tag> Goods_tag { get; set; }
        public virtual DbSet<Language_list> Language_list { get; set; }
        public virtual DbSet<Like_dislike_list> Like_dislike_list { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<News_category_list> News_category_list { get; set; }
        public virtual DbSet<News_tag> News_tag { get; set; }
        public virtual DbSet<Online_list> Online_list { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<Places_category_list> Places_category_list { get; set; }
        public virtual DbSet<Places_tag> Places_tag { get; set; }
        public virtual DbSet<Poster> Poster { get; set; }
        public virtual DbSet<Poster_category_list> Poster_category_list { get; set; }
        public virtual DbSet<Poster_tag> Poster_tag { get; set; }
        public virtual DbSet<Room_chat_id> Room_chat_id { get; set; }
        public virtual DbSet<Sex_list> Sex_list { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Shop_goods_list> Shop_goods_list { get; set; }
        public virtual DbSet<Skin_list> Skin_list { get; set; }
        public virtual DbSet<Status_list> Status_list { get; set; }
        public virtual DbSet<Sys_message> Sys_message { get; set; }
        public virtual DbSet<Tag_list> Tag_list { get; set; }
        public virtual DbSet<User_settings> User_settings { get; set; }
        public virtual DbSet<User_tag> User_tag { get; set; }
        public virtual DbSet<User_use_tag> User_use_tag { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<All_chat>()
                .Property(e => e.All_chat_mess_body)
                .IsFixedLength();

            modelBuilder.Entity<Announcement>()
                .Property(e => e.Announcement_tema)
                .IsFixedLength();

            modelBuilder.Entity<Announcement>()
                .Property(e => e.Announcement_body)
                .IsFixedLength();

            modelBuilder.Entity<Announcement>()
                .HasMany(e => e.Comments_announcement)
                .WithRequired(e => e.Announcement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Announcement_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Announcement_category_list>()
                .HasMany(e => e.Announcement)
                .WithRequired(e => e.Announcement_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Auctioneer>()
                .Property(e => e.Auctioneer_name)
                .IsFixedLength();

            modelBuilder.Entity<Auctioneer>()
                .Property(e => e.Auctioneer_comment)
                .IsFixedLength();

            modelBuilder.Entity<Auctioneer>()
                .Property(e => e.Auctioneer_direction)
                .IsFixedLength();

            modelBuilder.Entity<Auctioneer>()
                .HasOptional(e => e.Auctioneer_history)
                .WithRequired(e => e.Auctioneer);

            modelBuilder.Entity<Auctioneer_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Auctioneer_category_list>()
                .HasMany(e => e.Auctioneer)
                .WithRequired(e => e.Auctioneer_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Auctioneer_history>()
                .Property(e => e.Auc_history_action)
                .IsFixedLength();

            modelBuilder.Entity<Blog_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Blog_category_list>()
                .HasMany(e => e.Blog_list)
                .WithRequired(e => e.Blog_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blog_list>()
                .Property(e => e.Blog_status)
                .IsFixedLength();

            modelBuilder.Entity<Blog_list>()
                .Property(e => e.Blog_name)
                .IsFixedLength();

            modelBuilder.Entity<Blog_list>()
                .Property(e => e.Blog_slogon)
                .IsFixedLength();

            modelBuilder.Entity<Blog_list>()
                .HasOptional(e => e.Blog_user_table)
                .WithRequired(e => e.Blog_list);

            modelBuilder.Entity<Blog_post_comments>()
                .Property(e => e.Blog_post_com_body)
                .IsFixedLength();

            modelBuilder.Entity<Blog_post_table>()
                .Property(e => e.Blog_post_tema)
                .IsFixedLength();

            modelBuilder.Entity<Blog_post_table>()
                .Property(e => e.Blog_post_body)
                .IsFixedLength();

            modelBuilder.Entity<Blog_post_table>()
                .HasMany(e => e.Blog_post_comments)
                .WithRequired(e => e.Blog_post_table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blog_status_list>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<Blog_status_list>()
                .HasMany(e => e.Blog_user_table)
                .WithRequired(e => e.Blog_status_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.All_chat)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.Announcement)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.Auctioneer)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.Poster)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.Places)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City_list>()
                .HasMany(e => e.News)
                .WithRequired(e => e.City_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comments_announcement>()
                .Property(e => e.Com_announcement_body)
                .IsFixedLength();

            modelBuilder.Entity<Comments_eshop>()
                .Property(e => e.Comments_eshop_body)
                .IsFixedLength();

            modelBuilder.Entity<Comments_news>()
                .Property(e => e.Com_news_body)
                .IsFixedLength();

            modelBuilder.Entity<Comments_places>()
                .Property(e => e.Com_plases_body)
                .IsFixedLength();

            modelBuilder.Entity<Comments_poster>()
                .Property(e => e.Com_poster_body)
                .IsFixedLength();

            modelBuilder.Entity<Country_list>()
                .Property(e => e.Country)
                .IsFixedLength();

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.Announcement)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.Auctioneer)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.Poster)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.Places)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country_list>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Country_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Goods_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Goods_photo_id>()
                .Property(e => e.Goods_photo_path)
                .IsFixedLength();

            modelBuilder.Entity<Goods_photo_id>()
                .Property(e => e.Goods_photo_comments)
                .IsFixedLength();

            modelBuilder.Entity<Language_list>()
                .Property(e => e.Language)
                .IsFixedLength();

            modelBuilder.Entity<Language_list>()
                .HasMany(e => e.User_settings)
                .WithOptional(e => e.Language_list)
                .HasForeignKey(e => e.User_settings_language_id);

            modelBuilder.Entity<News>()
                .Property(e => e.News_tema)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.News_body)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .HasMany(e => e.Comments_news)
                .WithRequired(e => e.News)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<News_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<News_category_list>()
                .HasMany(e => e.News)
                .WithRequired(e => e.News_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Places>()
                .Property(e => e.Places_tema)
                .IsFixedLength();

            modelBuilder.Entity<Places>()
                .Property(e => e.Places_body)
                .IsFixedLength();

            modelBuilder.Entity<Places>()
                .HasMany(e => e.Comments_places)
                .WithRequired(e => e.Places)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Places_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Places_category_list>()
                .HasMany(e => e.Places)
                .WithRequired(e => e.Places_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Poster>()
                .Property(e => e.Poster_tema)
                .IsFixedLength();

            modelBuilder.Entity<Poster>()
                .Property(e => e.Poster_body)
                .IsFixedLength();

            modelBuilder.Entity<Poster>()
                .HasMany(e => e.Comments_poster)
                .WithRequired(e => e.Poster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Poster_category_list>()
                .Property(e => e.Category)
                .IsFixedLength();

            modelBuilder.Entity<Poster_category_list>()
                .HasMany(e => e.Poster)
                .WithRequired(e => e.Poster_category_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room_chat_id>()
                .Property(e => e.Room_name)
                .IsUnicode(false);

            modelBuilder.Entity<Sex_list>()
                .Property(e => e.Sex)
                .IsFixedLength();

            modelBuilder.Entity<Shop>()
                .Property(e => e.Shop_slogon)
                .IsFixedLength();

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Comments_eshop)
                .WithRequired(e => e.Shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Shop_goods_list)
                .WithRequired(e => e.Shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop_goods_list>()
                .Property(e => e.Goods_name)
                .IsFixedLength();

            modelBuilder.Entity<Shop_goods_list>()
                .Property(e => e.Goods_description)
                .IsFixedLength();

            modelBuilder.Entity<Shop_goods_list>()
                .HasMany(e => e.Goods_photo_id)
                .WithOptional(e => e.Shop_goods_list)
                .HasForeignKey(e => new { e.Goods_id, e.Shop_id });

            modelBuilder.Entity<Skin_list>()
                .Property(e => e.Skin_name)
                .IsFixedLength();

            modelBuilder.Entity<Skin_list>()
                .HasMany(e => e.User_settings)
                .WithOptional(e => e.Skin_list)
                .HasForeignKey(e => e.User_settings_skin_id);

            modelBuilder.Entity<Status_list>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<Status_list>()
                .HasMany(e => e.Online_list)
                .WithRequired(e => e.Status_list)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_message>()
                .Property(e => e.Sys_message1)
                .IsFixedLength();

            modelBuilder.Entity<Tag_list>()
                .Property(e => e.Tag_name)
                .IsFixedLength();

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Announcement_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Auctioneer_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Blog_post_comments_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Blog_post_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Chat_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Comments_announcement_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Comments_news_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Comments_places_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Comments_poster_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Goods_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.News_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Places_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.Poster_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.User_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<Tag_list>()
                .HasOptional(e => e.User_use_tag)
                .WithRequired(e => e.Tag_list);

            modelBuilder.Entity<User_settings>()
                .Property(e => e.User_settings_gps)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_premium_status)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_name)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_firstname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_lastname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_tel)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_nikname)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_password)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_email)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_avator)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_location)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.User_slogon)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.All_chat)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Announcement)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Auctioneer)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Blog_user_table)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Like_dislike_list)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.News)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Online_list)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Places)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Poster)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.Sys_message)
                .WithRequired(e => e.Users);

            modelBuilder.Entity<Users>()
                .HasOptional(e => e.User_settings)
                .WithRequired(e => e.Users);
        }
    }
}
