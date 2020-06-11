using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.ViewModels
{
    public class IndexAlbumsViewModel
    {
        public SelectList Artists { get; set; }
        public SelectList Genres { get; set; }

        public List<Album> Albums { get; set; }

        public int genreId { get; set; }
        public int artistId { get; set; }
        public string searchString { get; set; }
    }
}
