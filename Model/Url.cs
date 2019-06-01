using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Url
    {
        public long UrlId { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
        public string CreateDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
