using Business.Dtos;
using Business.Factories;
using Business.Models;
using Business.Services;

namespace ConsoleAppCsharp.Services;

public class MenuServices
{
    private readonly UserService _userService = new();

    

    public void CreateUserDialog()
    {
        Console.Clear();
        Console.WriteLine("Välkommen till min registreringssida!");
        UserRegistrationForm user = UserFactory.Create();
        User user1 = new();

        Console.Write("Skriv in ditt förnamn: ");
        user.firstName = Console.ReadLine()!;

        Console.Write("Skriv ditt efternamn: ");
        user.lastName = Console.ReadLine()!;

        Console.Write("Vänligen uppge din email adress: ");
        user.email = Console.ReadLine()!;

        Console.Write("Vänligen skriv din adress: ");
        user.adress = Console.ReadLine()!;


        _userService.Add(user);
    }

    public void ViewAllUserDialog()
    {
        Console.Clear();
        var users = _userService.GetAll();

        foreach (var user in users)
        {
            Console.WriteLine($"{"Id:",-10} {user.Id}");
            Console.WriteLine($"{"Name:",-10}{user.FirstName} {user.LastName}");
            Console.WriteLine($"{"Email:",-10}{user.Email}");
            Console.WriteLine($"{"Adress:",-10}{user.Adress}");
            Console.WriteLine("");
        }
        Console.ReadKey();
    }
}

