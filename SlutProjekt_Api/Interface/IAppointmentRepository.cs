using SlutProjekt_Api.Dto;

namespace SlutProjekt_Api.Interface
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentDto>> GetAllAppointments();
        Task<IEnumerable<AppointmentDto>> GetAppointments(DateTime? startDate, DateTime? endDate, int? companyId, string sortField, bool ascending);
    }
}
