﻿using System;
namespace BizModels.Model
{
    public class Post
    {
        public string Id { get; set; }
        public Business Business { get; set; }
        public string Discount { get; set; }
        public string Caption { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsImage => ImageUrl != null && ImageUrl != String.Empty;
    }
}

