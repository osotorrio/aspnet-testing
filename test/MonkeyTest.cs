namespace test;

public class MonkeyTest
{
    [Fact]
    public async Task Monkeys()
    {
        // Arrange
        var fixture = new TextFixture();

        // Act
        var response = await fixture.Client.GetAsync("Config");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Equal("local", content);
    }
}