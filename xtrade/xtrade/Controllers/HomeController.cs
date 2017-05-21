using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace xtrade.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "XTrade Webapp, built using ASP.NET MVC framework";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our Headquarters!!";

            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                //message.To.Add(new MailAddress("bmanojreddy9@gmail.com")); //replace with valid value
                message.To.Add(new MailAddress(model.FromEmail));
                message.Subject = "Your XTrade Query has been registered";
                //message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.Body = "<html><head><meta content=\"text/html; charset=utf-8\" /></head><body><p>Dear " + model.FromName +", </p> <p>Your query regarding the following issue has been registered.</p><p>"+ model.Message + "</p><p> Your Email: " + model.FromEmail + "</p><p>You will receive an update soon. Thank you for using XTrade</p> <br>++++++++++ </a></p><div>Best regards,</div><div>Team XTrade</div></body></html>";
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }
    }
}