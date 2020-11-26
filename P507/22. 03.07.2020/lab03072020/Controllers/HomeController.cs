using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab03072020.Models;
using System.Net.Mail;
using System.Net;

namespace lab03072020.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMail()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SendMail(Client client)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("p114code@gmail.com", "Group P114");
            mail.To.Add(new MailAddress(client.Email));

            mail.Subject = client.Subject;
            mail.CC.Add(new MailAddress(client.CC));
            mail.Body = $"<h2 style='color:red;'>test email to {client.Name} {client.Surname}</h2> <p>{client.Message}</p>";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("p114code@gmail.com", "123456p114");
            smtp.Send(mail);


            return RedirectToAction(nameof(Index));
        }
    }
}
