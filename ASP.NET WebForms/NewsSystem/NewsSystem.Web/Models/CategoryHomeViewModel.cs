using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSystem.Web.Models
{
    public class CategoryHomeViewModel
    {
        public string CategoryName { get; set; }

        public IList<Article> Articles { get; set; }
    }
}