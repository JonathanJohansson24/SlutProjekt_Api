using SlutProjekt_Api.Dto;

namespace SlutProjekt_Api.Interface
{
    public interface ICompanyAppointmentRepository
    {
        Task<AppointmentDto> AddCompanyAppointment(AppointmentDto entity);
        Task<AppointmentDto> UpdateCompanyAppointment(AppointmentDto entity);
        Task<AppointmentDto> DeleteCompanyAppointment(int id);
        Task LogCompanyChange(int appointmentId, int customerId, int companyId, string action);
    }
}
