using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDuca_test1.Models
{
    public class Season
    {
        public int ID { get; set; }
        public int SeasonNumber { get; set; }
        public String ArtworkUri { get; set; }
        public long ViewCount { get; set; }
        public long DownloadCount { get; set; }
        public virtual TvShow TvShow { get; set; }
    }
}