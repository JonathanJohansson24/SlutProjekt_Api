using System.ComponentModel.DataAnnotations;

namespace SlutProjekt_Api.Dto.Requests
{
    public class CreateCompany
    {
        public string CompanyName { get; set; }
    
        public string CompanyEmail { get; set; }

        public string Password { get; set; }
    }
}
