using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models.ViewModels
{
    public class ArtistsIndexViewModel
    {
        public List<Artist> Artists { get; set; }
        public char[] Letters { get; set; }
        public string letter { get; set; }
    }
}