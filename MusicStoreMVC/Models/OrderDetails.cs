﻿using System;
using System.Collections.Generic;

namespace MusicStoreMVC.Models
{
    public partial class OrderDetails
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int AlbumId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Orders Order { get; set; }
    }
}
