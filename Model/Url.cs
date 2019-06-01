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
        [Required]
        [MaxLength(100)]
        [RegularExpression("^((ftp|http|https)://)?(www.)?(?!.*(ftp|http|https|www.))[a-zA-Z0-9_-]+(.[a-zA-Z]+)+((/)[w#]+)*(/w+?[a-zA-Z0-9_]+=w+(&[a-zA-Z0-9_]+=w+)*)?$")]
        [Display(Name = "آدرس URL")]
        public string LongUrl { get; set; }
        [MaxLength(100)]
        [Display(Name = "آدرس URL کوتاه شده")]
        public string ShortUrl { get; set; }
        [StringLength(19)]
        public string CreateDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
