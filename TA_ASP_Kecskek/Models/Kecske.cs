using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TA_ASP_Kecskek.Models
{
    [Table("Kecskek")]
    public class Kecske
    {
        [Key, Required]
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Szin { get; set; }
        public string Kep { get; set; }
        public bool HotDeal { get; set; }
    }
}