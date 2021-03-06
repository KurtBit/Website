﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlogCMS.Web.Models
{
    public class ProjectsViewModel
    {
        public int OwnerId { get; set; }
        public int IsDeleted { get; set; }
        [MaxLength(256)]
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public TimeSpan? TimeSpan { get; set; }
        public string Url { get; set; }
        public string ImgFrameUrl { get; set; }
    }
}