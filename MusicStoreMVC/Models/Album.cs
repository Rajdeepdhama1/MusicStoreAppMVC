using System;
using System.Collections.Generic;

namespace MusicStoreMVC.Models
{
    public partial class Album
    {
        public Album()
        {
            Carts = new HashSet<Carts>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
        public virtual ICollection<Carts> Carts { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
