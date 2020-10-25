using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;


namespace RichTextEditor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendMail()
        {
            string recipient = Request["to"];
            string subject = Request["subject"];
            string body = Request["body"];

            WebMail.SmtpServer = "smtp.gmail.com";
            WebMail.SmtpPort = 587;
            WebMail.SmtpUseDefaultCredentials = true;
            WebMail.EnableSsl = true;
            WebMail.UserName = "Email address";
            WebMail.Password = "Password";

            WebMail.Send(to: recipient, subject: subject, body: body, isBodyHtml: true);

            return View();
        }
    }
}