using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AMETAP.Controller.Script
{
    public class Mailing
    {
        private String host;
        private String subject;
        private String body;

        public Mailing(String host,String subject,String body)
        {
            this.host = host;
            this.subject = subject;
            this.body = body;
        }

        public String getHost()
        {
            return this.host;
        }

        public String getSubject()
        {
            return this.subject;
        }

        public String getBody()
        {
            return this.body;
        }


        public void setHost(String host)
        {
            this.host = host;
        }
        public void setSubject(String subject)
        {
            this.subject = subject;
        }

        public void setBody(String body)
        {
            this.body = body;
        }

        public void sendMail(System.Collections.Generic.List<String> list)
        {
            try
            {
                MailMessage mm = new MailMessage("habibha.aroua82@gmail.com",getHost(),getSubject(),getBody());
                //foreach(String l in list)
                //{
                  //  mm.CC.Add(l);
                //}
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.Credentials = new NetworkCredential("habibha.aroua82@gmail.com", "habib.aroua@hotmail.framour88","");
                sc.EnableSsl = true;
                sc.Send(mm);
            }
            catch (Exception)
            {
            }
        }

        public void sendMail()
        {
            try
            {
                MailMessage mm = new MailMessage("habibha.aroua82@gmail.com", getHost(), getSubject(), getBody());
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.Credentials = new NetworkCredential("habibha.aroua82@gmail.com", "habib.aroua@hotmail.framour88", "");
                sc.EnableSsl = true;
                sc.Send(mm);
            }
            catch (Exception)
            {
            }
        }
    }
}
