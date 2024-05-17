using SlutProjekt_ApiModels;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SlutProjekt_Api.Dto
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
       
        public string Phone { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        
        public ICollection<AppointmentDto> Appointments { get; set; }

    }
}
