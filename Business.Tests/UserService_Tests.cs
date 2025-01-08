using System.Linq;
using Business.Dtos;
using Business.Models;
using Business.Services;

namespace Business.Tests;

public class UserService_Tests
{


    [Fact]
    public void Add_ShouldAddUserToList()
    {
        //arrange
        var userService = new UserService();
        var userRegistrationForm = new UserRegistrationForm()
        {
            firstName = "Test",
            lastName = "Testsson",
            email = "Test@domain.com",
            adress = "Rundgatan",
            CreatedDate = DateTime.Now,

        };

        var userRegistrationForm2 = new UserRegistrationForm()
        {
            firstName = "Test2",
            lastName = "Testsson2",
            email = "test2@domain.com",
            adress = "Testgatan",
            CreatedDate = DateTime.Now,

        };

        //act
        userService.Add(userRegistrationForm);
        userService.Add(userRegistrationForm2);

        //assert
        var users = userService.GetAll();
       


    }

    [Fact]
    public void GetAll_ShouldReturnSavedUsersFromFile()
    {

        //Arrange
        var fileService = new FileService();
        var userService = new UserService();

        //Act
        var users = userService.GetAll().ToList();

        //Assert
        Assert.NotNull(users);
        Assert.Equal(2, users.Count());
        Assert.Equal("Test", users[0].FirstName);
        Assert.Equal("Test2", users[1].FirstName);



    }
}
