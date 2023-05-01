namespace SuportesBalanceados.Test;

public class BrackValidatorTest
{
    private BracketValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new BracketValidator();
    }

    [Test]
    public void IsValid_WithValidSequence_ReturnsTrue()
    {
        // Arrange
        var sequence = "()[{()}](){}";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValid_WithInvalidSequence_ReturnsFalse()
    {
        // Arrange
        var sequence = "[{()}]({})]";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValid_WithEmptySequence_ReturnsTrue()
    {
        // Arrange
        var sequence = "";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsValid_WithSingleOpeningBracket_ReturnsFalse()
    {
        // Arrange
        var sequence = "(";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValid_WithSingleClosingBracket_ReturnsFalse()
    {
        // Arrange
        var sequence = ")";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsValid_WithOddNumberOfBrackets_ReturnsFalse()
    {
        // Arrange
        var sequence = "()[]{";

        // Act
        var result = _validator.IsValid(sequence);

        // Assert
        Assert.IsFalse(result);
    }
}