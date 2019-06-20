using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Angular2MVC.DBContext;

namespace Angular2MVC.Controllers
{
    public class RegisterAPIController : BaseAPIController
    {
        public HttpResponseMessage Get()
        {
            return ToJson(UserDB.TblRegisters.AsEnumerable());
        }

        public HttpResponseMessage Post([FromBody]TblRegister value)
        {
            UserDB.TblRegisters.Add(value);
            return ToJson(UserDB.SaveChanges());
        }

        //public HttpResponseMessage Put(int id, [FromBody]TblRegister value)
        //{
        //    UserDB.Entry(value).State = EntityState.Modified;
        //    return ToJson(UserDB.SaveChanges());
        //}
        //public HttpResponseMessage Delete(int id)
        //{
        //    UserDB.TblRegisters.Remove(UserDB.TblRegisters.FirstOrDefault(x => x.Id == id));
        //    return ToJson(UserDB.SaveChanges());
        //}
    }
}
