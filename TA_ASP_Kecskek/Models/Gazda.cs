using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TA_ASP_Kecskek.Models
{
    [Table("Gazdak")]
    public class Gazda
    {
        [Key, Required]
        public int Id { get; set; }
        public DateTime? SzulDatum { get; set; }
        public string Nev { get; set; }
        public int IrSzam { get; set; }
    }
}