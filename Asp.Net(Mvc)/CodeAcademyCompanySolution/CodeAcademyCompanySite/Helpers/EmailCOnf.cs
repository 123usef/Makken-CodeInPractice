using CodeAcademyCompany.DAL.Model;
using System.Net;
using System.Net.Mail;

namespace CodeAcademyCompany.PL.Helpers
{
	public  class EmailCOnf
	{
		public static void ResetPasswordEmail(Email em)
		{
								// using Google Mailing Services
			var client = new SmtpClient("smtp.gmail.com", 465);
			client.EnableSsl = true;
			//								account Credentials  ||  Passwrod Generated Once 
			client.Credentials = new NetworkCredential("YourEmail" , "*************");
			client.Send("SenderEmail", em.To, em.title, em.Body);
			
		}

	}
}
