

namespace ConsoleAppCsharp.Services;


public class MainMenu
{

    private readonly MenuServices _menuServices = new();

    // Denna koden är genererad av ChatGpt 4o. Koden skickar ett meddelande med att valet av tangent blev felaktigt och att användaren ska testa igen.
    private void InvalidOption(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Tryck valfri tangent för att fortsätta.");
        Console.ReadKey();
    }
    //
    public void CreateMainMenu()
    {

        bool isRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Välkommen, vänligen välj vad du vill göra.");
            Console.WriteLine("1.Registrera en användare");
            Console.WriteLine("2.Visa registrerade användera.");
            Console.WriteLine("Q.Avsluta programmet.");
            Console.WriteLine("**");
            Console.Write("Välj ditt alternativ: ");

            string option = Console.ReadLine()!;

            switch (option.ToLower())
            {
                case "1":
                    _menuServices.CreateUserDialog();
                    break;

                case "2":
                    _menuServices.ViewAllUserDialog();
                    break;

                case "q":
                    Console.Clear();
                    Console.WriteLine("Vänligen tryck på en tangent för att stänga programmet.");
                    Console.ReadKey();
                    isRunning = false; 
                    break;

                default:
                    InvalidOption("Felaktigt val, försök igen!");
                    break;
            }

        } while (isRunning);
        
    }

}

