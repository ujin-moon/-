﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Tournament
    {
        public Tournament() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Prize { get; set; }
    }
}