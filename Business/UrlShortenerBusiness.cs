using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Business
{
    public class UrlShortenerBusiness
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        
        public Url GenerateShortUrl(Url url)
        {
            var randomUrl =Generator.RandomURL.GetURL();
            var result = unitOfWork.UrlRepository.Get(x => x.LongUrl == url.LongUrl && !x.IsActive).FirstOrDefault();
            if (result == null)
            {
                var resultShortUrl = unitOfWork.UrlRepository.Get(x => x.ShortUrl == randomUrl && x.IsActive);
                while (resultShortUrl.Count() > 0)
                {
                    randomUrl = Generator.RandomURL.GetURL();
                    resultShortUrl = unitOfWork.UrlRepository.Get(x => x.ShortUrl == randomUrl && x.IsActive);
                    if (resultShortUrl.Count() == 0)
                        break;
                }

                url.ShortUrl = randomUrl;
                url.CreateDateTime = DateTime.UtcNow.ToFaString("yyyy/MM/dd hh:mm:ss");
                unitOfWork.UrlRepository.Insert(url);
                unitOfWork.Save();
            }
            else
            {
                url = result;
            }
            return url;
        }


    }
}
