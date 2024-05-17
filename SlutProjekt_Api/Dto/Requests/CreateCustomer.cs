namespace SlutProjekt_Api.Dto.Requests
{
    public class CreateCustomer
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
    }
}
