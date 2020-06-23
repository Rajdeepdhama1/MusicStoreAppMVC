using System;
using System.Collections.Generic;

namespace MusicStoreMVC.Models
{
    public partial class Carts
    {
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}
