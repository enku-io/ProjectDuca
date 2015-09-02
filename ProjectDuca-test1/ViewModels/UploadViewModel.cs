using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectDuca_test1.Models;

namespace ProjectDuca_test1.ViewModels
{
    public class UploadViewModel
    {
        public String MediaType { get; set; }
        public String Title { get; set; }
        public String DirectorName { get; set; }
        public String TvShowName { get; set; }
        public String SelectedGenre { get; set; }
        public String Description { get; set; }
        public String FileUri { get; set; }
        public String ArtworkUri { get; set; }
        public List<Genre> GenreList { get; set; }
        public DateTime Year { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        
    }
}