using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Net.Mime;

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

        public void sendMail()
        {
            try
            {
                MailMessage mm = new MailMessage("habibha.aroua82@gmail.com",getHost(),getSubject(),getBody());
                // content
                // Sending message
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);

                // our account credentials
                sc.Credentials = new NetworkCredential("habibha.aroua82@gmail.com", "habib.aroua@hotmail.framour88","");
                sc.EnableSsl = true;

                // Catching result

                sc.Send(mm);
                //MessageBox.Show("Message sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
