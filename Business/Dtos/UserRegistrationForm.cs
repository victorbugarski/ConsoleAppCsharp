using System.ComponentModel.DataAnnotations;

namespace Business.Dtos;

    public class UserRegistrationForm
    {
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string email { get; set; } = null!;
        public string adress { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }

