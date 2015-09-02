using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDuca_test1.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int ViewCount { get; set; }
        public int DownloadCount { get; set; }
    }
}