
using SlutProjekt_Api.Dto;
using SlutProjekt_Api.Dto.Requests;
using SlutProjekt_Api.Dto.Responses;
using SlutProjekt_ApiModels;

namespace SlutProjekt_Api.Interface
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers();
        Task<IEnumerable<CustomerDto>> GetCustomers(string name, string email, string sortField, bool ascending);
        Task<CustomerDto> GetCustomerById(int customerId);
        Task<CreateCustomerResponse> AddCustomer(CreateCustomer customer);
        Task UpdateCustomer(CustomerDto updatedCustomer); 

        Task DeleteCustomer(int customerId);
        Task<double> GetTotalBookingHoursForWeek(int customerId, int year, int weekNumber);
    }
}
