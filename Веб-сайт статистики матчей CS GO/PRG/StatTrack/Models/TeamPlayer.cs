using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StatTrack.Models
{
    
    public class TeamPlayer
    {
        [Key]
        public int Team_ID { get; set; }
        public int Player_ID { get; set; }
    }
}