using Business.Dtos;
using Business.Helpers;
using Business.Models;
namespace Business.Factories;

    public class UserFactory
    {
        public static UserRegistrationForm Create()
        {  return new UserRegistrationForm(); }

        public static User Create(UserRegistrationForm form)
        {
            return new User
            {
                Id = UniqueIdentifierGenerator.Generate(),
                FirstName = form.firstName,
                LastName = form.lastName,
                Email = form.email,
                Adress = form.adress,
                CreatedDate = DateTime.Now
            };
        }
    }

