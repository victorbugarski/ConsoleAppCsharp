using Business.Helpers;

namespace ConsoleAppCsharp.tests.Helpers;

public class UniqueIdentifierGenerator_Tests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        
        string id = UniqueIdentifierGenerator.Generate();

       
        Assert.False(string.IsNullOrEmpty(id));
        Assert.True(Guid.TryParse(id, out _));
    }
}
