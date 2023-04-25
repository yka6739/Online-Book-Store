using SendGrid.Helpers.Mail;
using SendGrid;

namespace BestShop.MyHelpers
{
    public class EmailSender
    {
        public static async Task SendEmail(string toEmail, string username, string subject, string message)

        {
            string apiKey = "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";
           // string apiKey = "Im2qpV_0QVOva_kZNwk4vw";


            var client = new SendGridClient(apiKey);

            var from = new EmailAddress("yatender79@gmail.com", "BestShop.com");
            var to = new EmailAddress(toEmail, username);
            var plainTextContent = message;
            var htmlContent = "";

            var msg = MailHelper.CreateSingleEmail(
                from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
        }
    }
}
