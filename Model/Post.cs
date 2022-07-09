using System;
namespace BizClient.Model
{
    public class Post : ObservableObject
    {
        public Post(PostResponse response)
        {
            //Id = response.Id;
            //Caption = response.Caption;
            //Image = response.Image;
            //CreatedAt = response.CreatedAt;
            //// TODO: resolve from BusinessService
            //BusinessName = "McDonalds";
            //BusinessImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";

            _id = "123";
            Caption = "This is a post";
            ImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
            createdAt = new DateTime();
            // TODO: resolve from BusinessService
            //BusinessName = "McDonalds";
            BusinessImageUrl = "https://st2.depositphotos.com/6331184/9676/i/450/depositphotos_96765686-stock-photo-homemade-hummus-with-pita-bread.jpg";
        }
        public Post(string id, string i_businessId, string i_content, string i_src, DateTime i_createdAt)
        {
            _id = id;
            businessId = i_businessId;
            content = i_content;
            src = i_src;
            createdAt = i_createdAt;
        }

        public string _id { get; set; }
        public string businessId { get; set; }
        public string content { get; set; }
        public string src { get; set; }
        public DateTime createdAt { get; set; }



        public string Caption { get; set; }
        public string ImageUrl { get; set; }
        public string BusinessImageUrl { get; set; }

        // TODO: move to seperate folder
        public class PostResponse
        {
            public string _id { get; set; }

            public string businessId { get; set; }

            public string Caption { get; set; }

            public string Image { get; set; }

            public DateTime CreatedAt { get; set; }
        }

        //    public string Id { get; set; }

        //    public string BusinessName { get; set; }

        //    public string BusinessImageUrl { get; set; }

        //    public string Caption { get; set; }

        //    public string ImageUrl { get; set; }

        //    public DateTime CreatedAt { get; set; }
        //}
    }

}

