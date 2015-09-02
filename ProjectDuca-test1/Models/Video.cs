using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDuca_test1.Models
{
    public class Video
    {
        public int ID {get; set;}
        public int Duration { get; set; }
        public String MediaKind { get; set; }
        public String ArtworkUri { get; set; }
        public String Description { get; set; }
        public String Title { get; set; }
        public String DirectorName { get; set; }
        public String LocationUri { get; set; }
        public DateTime Year { get; set; }
        public long ViewCount { get; set; }
        public long DownloadCount { get; set; }
        public virtual TvShowEpisodeInfo EpisodeInfo { get; set; }
        public virtual Genre Genre { get; set; }
    }
}