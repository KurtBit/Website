﻿using System;

namespace BlogCMS.Web.Areas.Admin.Models
{
    public class PostsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public DateTime PostedAt { get; set; }
        public int IsDeleted { get; set; }
    }
}