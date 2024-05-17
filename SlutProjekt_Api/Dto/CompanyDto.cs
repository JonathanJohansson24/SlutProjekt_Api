
using SlutProjekt_ApiModels;
using System.ComponentModel.DataAnnotations;

namespace SlutProjekt_Api.Dto
{
    public class CompanyDto
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        
        public string CompanyEmail { get; set; }

    }
}
