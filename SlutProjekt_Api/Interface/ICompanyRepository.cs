
using SlutProjekt_Api.Dto;
using SlutProjekt_Api.Dto.Requests;
using SlutProjekt_Api.Dto.Responses;
using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Interface
{
    public interface ICompanyRepository
    {
        Task<List<AppointmentDto>> GetAppointmentsByDateRange(DateTime startDate, DateTime endDate, int companyId);
        Task<IEnumerable<CompanyDto>> GetAllCompanies();
        Task<CreateCompanyResponse> AddCompany(CreateCompany company);
      
    }
}
