using AutoMapper;
using CodeAcademyCompany.DAL.Model;
using CodeAcademyCompany.PL.ViewModels;

namespace CodeAcademyCompany.PL.Model_Profile
{
    public class DepartmentProfile :Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentVM, Department>();
        }
    }
}
