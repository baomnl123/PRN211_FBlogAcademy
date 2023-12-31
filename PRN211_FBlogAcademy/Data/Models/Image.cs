﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Image
    {
        public Image()
        {
        }

        public int Id { get; set; }
        public int PostId { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public virtual Post Post { get; set; }
    }
}
