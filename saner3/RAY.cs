using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace saner3
{
    [Table("RAYS")]
    public class RAY
    {
        [Key]
        public string numara { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}