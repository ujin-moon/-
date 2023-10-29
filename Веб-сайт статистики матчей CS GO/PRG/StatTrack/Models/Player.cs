using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Player
    {
        public Player() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Nickname { get; set; }
    }

    public enum Role
    {
        Support,
        Sniper,
        Rifler,
        IGL
    }
}