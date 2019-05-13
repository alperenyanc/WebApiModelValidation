using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiModelValidation.Filters;
using WebApiModelValidation.Models;

namespace WebApiModelValidation.Controllers
{
    // bütün projeiy etkileyecek filter ı ewb confige yazdıktan sonta çakışmayı önlemek için controller tepesindeki attrubutleri siliyoruz

    // [MyModelValidationAttribute]
    public class UserController : ApiController
    {
        [HttpPost]//yeni kayıt metodu
        public HttpResponseMessage Post([FromBody] User user)
        {

            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.Created, "User created kullanici olusturuldu");
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"Kullanıcı oluşturulamadı");
        }

    }
}
