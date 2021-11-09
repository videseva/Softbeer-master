using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;


namespace BLL
{
    public class Correo
    {
        private MailMessage email;
        private SmtpClient smtp;

        public Correo()
        {
            smtp = new SmtpClient();

        }
        private void ConfigurarSmpt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("catorresmolina@unicesar.edu.co",
             "");
        }
        private void ConfigurarEmail(Proveedor proveedor)
        {
            email = new MailMessage();
            email.To.Add(proveedor.Correo);
            email.From = new MailAddress("torres@hotmail.com");
            email.Subject = "Registro de proveedor"
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {proveedor.PrimerNombre }</b> <br " +
                $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmail(Proveedor proveedor)
        {

            try
            {
                ConfigurarSmpt();
                ConfigurarEmail(proveedor);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }



    }
}
