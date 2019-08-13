using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class Picture:BaseEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }


    }
}