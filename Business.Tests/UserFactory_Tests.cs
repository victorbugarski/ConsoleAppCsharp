using Business.Dtos;
using Business.Factories;
using Business.Models;

namespace Business.Tests;

public class UserFactory_Tests
{
    [Fact]
    public void Create_ShouldReturnUserRegistrationForm()
    {
        //Arrange

        //Act
        var result = UserFactory.Create();

        //Assert
        Assert.NotNull(result);
        Assert.IsType<UserRegistrationForm>(result);
    }

    [Fact]

    public void Create_ShouldReturnUser_WhenUserRegistrationFormProvided()
    {
        //Arrange
        var userRegistrationForm = new UserRegistrationForm()
        {
            firstName = "Test",
            lastName = "Testsson",
            email = "Test@domain.com",
            adress = "Rundgatan",
            CreatedDate = DateTime.Now
        };

        //Act
        var result = UserFactory.Create(userRegistrationForm);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
    }
}
