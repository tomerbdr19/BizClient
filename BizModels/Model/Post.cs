using System;
namespace BizModels.Model
{
    public class Post
    {
        public string Id { get; set; }
        public Business Business { get; set; }
        public string Caption { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsImage { get
            {
                if (ImageUrl == null || ImageUrl == "")
                {
                    return false;
                }
                else
                {
                    return true;  
                }
            } 
        }
    }
}

