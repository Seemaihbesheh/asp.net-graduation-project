
using System;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebApplication3.UtilityService
{

    public class Emailservice //: IEmailService
    {
/*
        private readonly IConfiguration _config;

        public Emailservice(IConfiguration configuration)
        {
            _config = configuration;

        }
        /*

        //   create email messgae to reset password


        public void SendEmail(EmailModel emailModel)
        {
            var emailMeesgae = new MimeMessage();
            var from = _config["EmailSeetings:From"];//this me as admin
            emailMeesgae.From.Add(new MailboxAddress("Let's program", from));
            emailMeesgae.To.Add(new MailboxAddress(emailModel.To, emailModel.To));
            emailMeesgae.Subject = emailModel.Subject;
            emailMeesgae.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = string.Format(emailModel.Content)
            };


            //connsection 
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_config["EmailSeetings:SmtpServer"], 9876, true);

                    client.Authenticate(_config["EmailSeetings:From"], _config["EmailSeetings:password"]);
                    client.Send(emailMeesgae);

                }
                catch (Exception ex)
                {
                    throw;
                }

                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }


        }
        */

    }
}


