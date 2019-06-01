using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business;

namespace WebApplication.Controllers
{
    public class UrlShortenerApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get([FromUri]string key)
        {
            try
            {
                var business = new UrlShortenerBusiness();
                var longUrl = business.GetLongUrl(key);
                var response = Request.CreateResponse(HttpStatusCode.Moved);
                if (Uri.IsWellFormedUriString(longUrl, UriKind.Absolute))
                    response.Headers.Location = new Uri(longUrl);
                else
                    response.Headers.Location = new Uri("http://" + longUrl);
                return response;
            }
            catch (Exception ex)
            {
                var response = Request.CreateResponse(HttpStatusCode.NoContent);
                return response;
            }
        }
    }
}
