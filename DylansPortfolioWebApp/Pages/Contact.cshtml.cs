using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;

namespace DylansPortfolioWebApp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ContactModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var name = Request.Form["name"];
            var email = Request.Form["email"];
            var message = Request.Form["message"];
        }

        public bool SendMail(string name, string email, string message)
        {
            //MailMessage mailMessage = new MailMessage();
            //SmtpClient smtpClient = new SmtpClient();
            //mailMessage.From = new MailAddress(email);
            //mailMessage.To.Add("djrothbauer@gmail.com");
            //mailMessage.Subject = "Message from Portfolio";
            //mailMessage.Body = "<p>Name:" + name + "</p>" + "<p>Email:" + email + "</p>" + "<p>Message:" + message + "</p>";

            //smtpClient.Port // hosting provider?
            //smtpClient.Host // hosting provider?
            //smtpClient.EnableSsl = true;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new NetworkCredential(); // fill out the username and password
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.Send(message);
            return true;


        }

    }
}
