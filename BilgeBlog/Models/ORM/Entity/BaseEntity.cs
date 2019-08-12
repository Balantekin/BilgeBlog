using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilgeBlog.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }
        private DateTime? _addDate = DateTime.Now;
        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }
        private bool _isDeleted = false;
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = false; }
        }
        public DateTime DeleteDate { get; set; }



    }
}