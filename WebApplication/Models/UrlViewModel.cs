using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class UrlViewModel
    {
        [Required]
        [MaxLength(100)]
        [RegularExpression("^((ftp|http|https)://)?(www.)?(?!.*(ftp|http|https|www.))[a-zA-Z0-9_-]+(.[a-zA-Z]+)+((/)[w#]+)*(/w+?[a-zA-Z0-9_]+=w+(&[a-zA-Z0-9_]+=w+)*)?$")]
        [Display(Name = "آدرس سایت")]
        public string LongUrl { get; set; }
        [MaxLength(100)]
        [Display(Name = "آدرس سایت کوتاه شده")]
        public string ShortUrl { get; set; }
    }
}