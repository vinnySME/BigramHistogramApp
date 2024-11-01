using BigramHistogramApp;
namespace BigramHistogramApp.Tests;

[TestClass]
public sealed class BigramParserTests
{
    private BigramParser _parser;

    [TestInitialize]
    public void Setup()
    {
        _parser = new BigramParser();
    }

    [TestMethod]
    public void ParseTextToBigrams_ValidInput_ReturnsCorrectBigramCounts()
    {
        // Arrange
        string text = "She walked briskly through the park and through the woods.";

        // Expected bigrams and their counts
        var expected = new Dictionary<string, int>
         {
          { "she walked", 1 },
          { "walked briskly", 1 },
          { "briskly through", 1 },
          { "through the", 2 },
          { "the park", 1 },
          { "park and", 1 },
          { "and through", 1 },
          { "the woods", 1 }
        };

        // Act
        var result = _parser.ParseTextToBigrams(text);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }


    [TestMethod]
    public void ParseTextToBigrams_EmptyString_ThrowsArgumentException()
    {
        // Arrange
        string text = "";

        // Act & Assert
        Assert.ThrowsException<System.ArgumentException>(() => _parser.ParseTextToBigrams(text));
    }

    [TestMethod]
    public void ParseTextToBigrams_CaseInsensitive_HandlesCorrectly()
    {
        // Arrange
        string text = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps high. The fox is quick, and the fox is clever. Quick foxes jump over lazy dogs and lazy foxes jump over quick dogs.";
        var expected = new Dictionary<string, int>
    {
         { "the quick", 2 },
{ "quick brown", 2 },
{ "brown fox", 2 },
{ "fox jumps", 2 },
{ "jumps over", 1 },
{ "over the", 1 },
{ "the lazy", 1 },
{ "lazy dog", 1 },
{ "dog the", 1 },
{ "jumps high", 1 },
{ "high the", 1 },
{ "the fox", 2 },
{ "fox is", 2 },
{ "is quick", 1 },
{ "quick and", 1 },
{ "and the", 1 },
{ "is clever", 1 },
{ "clever quick", 1 },
{ "quick foxes", 1 },
{ "foxes jump", 2 },
{ "jump over", 2 },
{ "over lazy", 1 },
{ "lazy dogs", 1 },
{ "dogs and", 1 },
{ "and lazy", 1 },
{ "lazy foxes", 1 },
{ "over quick", 1 },
{ "quick dogs", 1 }
    };

        // Act
        var result = _parser.ParseTextToBigrams(text);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }

    [TestMethod]
    public void ParseTextToBigrams_IgnoresPunctuation()
    {
        // Arrange
        string text = "In the garden, she found peace. In the garden; she felt calm.";
        var expected = new Dictionary<string, int>
    {
        { "in the", 2 },
        { "the garden", 2 },
        { "garden she", 2 },
        { "she found", 1 },
        { "found peace", 1 },
        { "peace in", 1 },
        { "she felt", 1 },
        { "felt calm", 1 }
    };

        // Act
        var result = _parser.ParseTextToBigrams(text);

        // Assert
        CollectionAssert.AreEquivalent(expected, result);
    }
}
