﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Medical.Models
{
    public partial class OtherProductImage
    {
        public int OtherProductImageId { get; set; }
        public int ProductId { get; set; }
        public string OtherProductImage1 { get; set; }

        public virtual Product Product { get; set; }
    }
}
