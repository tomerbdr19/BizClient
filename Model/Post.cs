using System;
namespace BizClient.Model
{
    public class Post : ObservableObject
    {
        public Post(PostResponse response, string BusinessName, string BusinessImageUrl)
        {
            Id = response.Id;
            Caption = response.Caption;
            ImageUrl = response.Image;
            CreatedAt = response.CreatedAt;
            // TODO: resolve from BusinessService
            this.BusinessName = BusinessName;
            this.BusinessImageUrl = BusinessImageUrl;

            // Id = "123";
            // Caption = "This is a post";
            // ImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
            // CreatedAt = new DateTime();
            // // TODO: resolve from BusinessService
            // BusinessName = "McDonalds";
            // BusinessImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
        }

        public string Id { get; set; }

        public string BusinessName { get; set; }

        public string BusinessImageUrl { get; set; }

        public string Caption { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    // TODO: move to seperate folder
    public class PostResponse
    {
        public PostResponse(string Id, string BusinessId, string Caption, string Image, DateTime CreatedAt)
        {
            this.Id = Id;
            this.BusinessId = BusinessId;
            this.Caption = Caption;
            this.Image = Image;
            this.CreatedAt = CreatedAt;
        }

        public PostResponse() { }
        public string Id { get; set; }

        public string BusinessId { get; set; }

        public string Caption { get; set; }

        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }
    }

}

