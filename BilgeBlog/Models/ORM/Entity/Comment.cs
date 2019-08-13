using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class Comment:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }


    }
}