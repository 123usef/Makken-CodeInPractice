using System.ComponentModel.DataAnnotations;

namespace CodeAcademyCompany.PL.ViewModels
{
	public class ForgetPasswordVM
	{
		[EmailAddress]
		[Required(ErrorMessage ="Email is Required to reset your Password")]
        public string Email { get; set; }


    }
}
