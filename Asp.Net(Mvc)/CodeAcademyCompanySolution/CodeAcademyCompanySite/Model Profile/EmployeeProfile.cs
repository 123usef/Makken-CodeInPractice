using AutoMapper;
using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.ViewModels;

namespace CodeAcademyCompany.PL.Model_Profile
{
    public class EmployeeProfile :Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeVM, Employee>();
                //.ForMember( o=> o.EmpName ,   );
        }
    }
}
