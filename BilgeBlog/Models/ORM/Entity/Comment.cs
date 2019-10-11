using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class Comment:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private bool _isActive = false;
        public bool isActive {
            get
            {
                return _isActive;
            }
            set 
            {
                _isActive = value;
            }
        }
        public int BlogID { get; set; }
        [ForeignKey("BlogID")]
        public Blog Blog { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}