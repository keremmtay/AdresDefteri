using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri.Common.Helpers.EmailServices
{
    public class EmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private string _username;
        private string _password;
        private bool _enableSSL;

        public EmailSender(string host, int port, bool enableSSL, string username, string password)
        {
            this._enableSSL = enableSSL;
            this._host = host;
            this._port = port;
            this._username = username;
            this._password = password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_username, _password),
                EnableSsl = this._enableSSL
            };

            return client.SendMailAsync(
                new MailMessage(_username, email, subject, htmlMessage)
                {
                    IsBodyHtml = true
                });
        }
    }
}
