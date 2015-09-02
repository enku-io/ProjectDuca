using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDuca_test1.Models
{
    public class TvShowEpisodeInfo
    {
        public int ID { get; set; }
        public virtual TvShow TvShow { get; set; }
        public virtual Season Season { get; set; }
        public int EpisodeNumber { get; set; }
    }
}