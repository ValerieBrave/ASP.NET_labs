using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Lab5b.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        [HttpGet]
        [Route("{n:int}/{str}")]
        public string M01(int n, string str)
        {
            return $"GET:M01:/{n}/{str}";
        }

        [AcceptVerbs(HttpVerbs.Get | HttpVerbs.Post)]
        [Route("{b:bool}/{letters:alpha}")]
        public string M02(bool b, string letters)
        {
            return $"{Request.HttpMethod}:M02:/{b}/{letters}";
        }

        [AcceptVerbs("Get", "Delete")]
        [Route("{f:float}/{str:length(2,5)}")]
        public string M03(float f, string str)
        {
            return $"{Request.HttpMethod}:M03:/{f}/{str}";
        }
        //[HttpPut]
        [AcceptVerbs("Put")]
        [Route("{letters:alpha:length(3,4)}/{n:range(100,200)}")]
        public string M04(string letters, int n)
        {
            return $"{Request.HttpMethod}:M04:/{letters}/{n}";
        }

        [Route(@"{email:regex(^([\w.-]+)@([\w-]+)((.+(\w){2,3})+)$)}")]
        [HttpPost]
        public string M05(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return $"{Request.HttpMethod}:M05:/{email}";
            }
            catch (FormatException)
            {
                return $"{Request.HttpMethod}:M05:not valid E-mail";
            }
        }
        
    }
}