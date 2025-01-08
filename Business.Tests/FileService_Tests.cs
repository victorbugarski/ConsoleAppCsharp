using Business.Helpers;
using Business.Models;
using Business.Services;

namespace Business.Tests;

public class FileService_Tests
{
    private readonly string _testDirectory = "TestData";
    private readonly string _testFileName = "test_list.json";
    /// <summary>
    /// Denna kod är genererad av Chat gpt. 
    /// I Arrange delen så skapas en instans av FileService som sedan sparar filer i en katalog som i detta fall är _testDirectory och _testFileName namnger filen.
    /// I Act delen där testet faktiskt körs så kallar funktionen på SaveListToFile där man vill spara användaren ner till en specifik fil som är döpt till users i detta fallet.
    /// I Assert så testar koden ifall att filen finns och att namnet på användaren finns med i filen när den sparas ner.
    /// </summary>
    [Fact]
   
    public void SaveListToFile_ShouldCreateFileAndSaveContent()
    {
        if (Directory.Exists(_testDirectory))
            Directory.Delete(_testDirectory, true);
        //arrange
        var fileService = new FileService( _testDirectory, _testFileName );
        var users = new List<User>
        {
            new User {Id = "0", FirstName = "Test", LastName = "Testsson", Email = "test@domain.com", Adress = "Rundgatan"},
            new User {Id = "1", FirstName = "Test2", LastName = "Testsson2", Email = "test2@domain.com", Adress = "Testgatan"}

        };

        //act
        fileService.SaveListToFile(users);

        //assert
        var filePath = Path.Combine(_testDirectory, _testFileName );
        Assert.True(File.Exists( filePath ) );

        var fileContent = File.ReadAllText( filePath );
        Assert.Contains("Test2", fileContent);

    }
    /// <summary>
    /// Denna kod är genererad av Chat gpt.
    /// I Arrange delen så används FileService där man använder en katalog och en fil som i detta fallet är _tesFileName och _testDirectory. Efter det så skapas två stycken test användare i en ny lista. Och i det sista steget så anropar man en metod som i detta fall heter SaveListToFile och det som den funktionen gör är att den sparar ner listan till en fil.
    /// I Act delen så körs testet och returnerar listan på användare ifrån filen där den sparades ner till.
    /// I Assert så så kotrolleras först listan som heter loadedUsers så att den inte är tom. Efter det så görs en räkning på listan som i detta fall ska var 2. Skulle det inte vara 2 användare i listan så ger testet ett rött test eftersom det inte stämmer överens. Och i den sista delen så kotrolleras det ifall FirstName stämmer överens ifrån min laddade lista med det som finns i users.
    /// </summary>
    [Fact]
    public void LoadListFromFile_ShouldReturnSavedList()
    {
        //arrange
        var fileService = new FileService(_testFileName, _testDirectory);
        var users = new List<User>
        {
            new User { FirstName = "Test", LastName = "Testsson", Email = "Test@domain.com", Adress = "Rundgatan", CreatedDate = DateTime.Now},
            new User { FirstName = "Test2", LastName = "Testsson2", Email = "test2@domain.com", Adress = "Testgatan", CreatedDate = DateTime.Now }
        };

        fileService.SaveListToFile(users);

        //act
        var loadedUsers = fileService.LoadListFromFile();

        //assert
        Assert.NotNull(loadedUsers);
        Assert.Equal(2, loadedUsers.Count);
        Assert.Equal("Test", loadedUsers[0].FirstName);
        Assert.Equal("Test2", loadedUsers[1].FirstName);

    }

}
