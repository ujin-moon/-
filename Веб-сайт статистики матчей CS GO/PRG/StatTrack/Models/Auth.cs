using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatTrack.Models
{
    public class Auth
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}