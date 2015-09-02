using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDuca_test1.Models
{
    public class TvShow
    {
        public int ID { get; set; }
        public String ArtworkUri { get; set; }
        public String Description { get; set; }
        public String DirectorName { get; set; }
        public long ViewCount { get; set; }
        public long DownloadCount { get; set; }
    }
}