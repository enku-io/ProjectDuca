using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDuca_test1.DAL;
using ProjectDuca_test1.ViewModels;

namespace ProjectDuca_test1.Controllers
{
    public class UploadController : Controller
    {
        private DucaContext db = new DucaContext();
        public ActionResult Upload()
        {
            UploadViewModel uploadView = new UploadViewModel();
            uploadView.GenreList = db.Genres.ToList();
            
            return View(uploadView);
        }
        public PartialViewResult MovieUpload
            (string artwork ,string title ,string description ,int year,string genre,string director)
        {
            if (title != null && description != null && year > 1900 && genre != null && director != null)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase uploadedFile = Request.Files[i];
                    if (uploadedFile!= null && uploadedFile.ContentType.Contains("image"))
                    {
                        var Directory = new DirectoryInfo(String.Format("{0}\\Images\\MovieArtworks",Server.MapPath(@"\")));
                        if (!Directory.Exists)
                            System.IO.Directory.CreateDirectory(Directory.ToString());
                        var filePath = String.Format("{0}\\{1}",Directory,Path.GetFileName(uploadedFile.FileName));
                        uploadedFile.SaveAs(filePath);
                    }
                    else if(uploadedFile != null)
                    {
                        var Directory = new DirectoryInfo(String.Format("{0}\\Videos\\Movies\\{1}\\{2}",Server.MapPath(@"\"),genre,year));
                        if (!Directory.Exists)
                            System.IO.Directory.CreateDirectory(Directory.ToString());
                        var filePath = String.Format("{0}\\{1}", Directory,Path.GetFileName(uploadedFile.FileName) );
                        uploadedFile.SaveAs(filePath);
                    } 
                }
                return PartialView("MovieUpload");                
            }
            else
            {
                return PartialView("MovieUpload");
            }
        }

        public PartialViewResult TvShowUpload(string title, string description, int year, string genre, string director,
            string tvshow, int seasonNumber, int episodeNumber)
        {
            return PartialView("MovieUpload");
        }
    }
}
