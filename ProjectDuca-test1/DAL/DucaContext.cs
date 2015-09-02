using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectDuca_test1.Models;

namespace ProjectDuca_test1.DAL
{
    public class DucaContext :DbContext
    {
        public DucaContext() : base("DucaContext"){}

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<TvShow> TvShows { get; set; }
        public DbSet<TvShowEpisodeInfo> TvShowEpisodeInfos { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}