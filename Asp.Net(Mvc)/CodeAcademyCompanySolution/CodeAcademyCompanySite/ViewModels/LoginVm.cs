using System.ComponentModel.DataAnnotations;

namespace CodeAcademyCompany.PL.ViewModels
{
	public class LoginVm
	{
		[EmailAddress]
        public string Email{ get; set; }
        [DataType(DataType.Password)]
        public string  Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
