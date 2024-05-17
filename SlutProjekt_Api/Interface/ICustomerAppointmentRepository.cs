using SlutProjekt_Api.Dto;

namespace SlutProjekt_Api.Interface
{
    public interface ICustomerAppointmentRepository
    {
        Task<AppointmentDto> AddCustomerAppointment(AppointmentDto entity);
        Task<AppointmentDto> UpdateCustomerAppointment(AppointmentDto entity);
        Task<AppointmentDto> DeleteCustomerAppointment(int id);
        Task LogCustomerChange(int appointmentId, int customerId, int companyId, string action);
    }
}
