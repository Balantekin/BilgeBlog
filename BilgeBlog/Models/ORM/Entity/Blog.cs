﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public string ImagePath { get; set; }

        public int NumberofViews { get; set; }
        public int NumberofLikes { get; set; }
        public int CommentID { get; set; }


    }
}