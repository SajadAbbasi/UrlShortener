using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Url
    {
        [Key]
        public long UrlId { get; set; }
        [StringLength(100)]
        [Required]
        public string LongUrl { get; set; }
        [StringLength(100)]
        [Required]
        public string ShortUrl { get; set; }
        [StringLength(5)]
        [Required]
        public string Key { get; set; }
        [StringLength(19)]
        [Required]
        public string CreateDateTime { get; set; }
        public bool IsActive { get; set; }
        public long Click { get; set; }
    }
}
