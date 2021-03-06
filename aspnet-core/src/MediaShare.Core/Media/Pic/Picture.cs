﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaShare.Media.Pic
{
    public class Picture : Entity
    {
        public string FileName { get; set; }

        public string RealPath { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Size { get; set; }

        public string Title { get; set; }

        public DateTime RecordDate { get; set; }

        public int ViewCount { get; set; }

        public virtual ICollection<PicTagRelation> PicTagRelation { get; set; }

        public virtual ICollection<PicFavRelation> PicFavRelation { get; set; }
    }
}
