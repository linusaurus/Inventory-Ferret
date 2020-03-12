
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using DataLayer.Entities;
using System.Windows.Forms;
using System.Web.UI;



namespace Weaselware.InventoryFerret
{


    public static class NotificationService {

        public static void SendNotificaion(string toAddress, PurchaseOrder order) {


            StringWriter stringWriter = new StringWriter();
            System.Web.UI.HtmlTextWriter writer = new System.Web.UI.HtmlTextWriter(stringWriter);
            
          
           
            String userName = "designsynthesis.notifications@gmail.com";
            String password = "Kx09a32x";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName, password)
            };

            System.Net.Mail.MailMessage msg = new MailMessage("alerts@designsynthesis.net", toAddress);
            msg.IsBodyHtml = true;
            msg.From = new MailAddress("alerts@designsynthesis.net","Knoodle-Receiving");
            msg.Subject = string.Format("Order Number : {0} ", order.OrderNum.ToString());


            //writer.WriteBeginTag("p");
            //writer.Write(writer.TagRightChar);
            //writer.Write(string.Format("Order Number : {0} Has Been Recieved, Job = {1}", order.OrderNum.ToString(), order.Job.Jobname.ToString()));
            //writer.WriteEndTag("p");

            //writer.WriteBeginTag("table");
            //writer.Write(">");

            //foreach (PurchaseLineItem item in order.PurchaseLineItem)
            //{

            //    writer.WriteBeginTag("tr");
            //    writer.Write(writer.);
            //    writer.WriteBeginTag("td");
            //    writer.Write(HtmlTextWriter.TagRightChar);
            //    writer.Write(item.LineID.ToString().PadRight(5) + "--> ");
            //    writer.WriteEndTag("td");

            //    writer.WriteBeginTag("td");
            //    writer.Write(HtmlTextWriter.TagRightChar);
            //    writer.Write(item.Qnty.ToString());
            //    writer.WriteEndTag("td");

            //    writer.WriteBeginTag("td");
            //    writer.Write(HtmlTextWriter.TagRightChar);
            //    writer.Write(item.Description.ToString());
            //    writer.WriteEndTag("td");

            //    writer.WriteEndTag("tr");
            //}

            //writer.WriteEndTag("table");
            //msg.MailAddress = true;
            msg.Body = stringWriter.ToString();

          
           
            smtp.Send(msg);
        }
    }
}
