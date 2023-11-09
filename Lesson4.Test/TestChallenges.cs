using FluentAssertions;

namespace Lesson4.Test;

public class TestChallenges
{
    [Fact]
    public void IsPalindrome_CalledWithInvalidPalindrome_ReturnsFalse()
    {
        var result = Challenges.IsPalindrome("grammar");
        result.Should().BeFalse();
    }

    [Fact]
    public void IsPalindrome_CalledWithValidPalindrome_ReturnsTrue()
    {
        throw new NotImplementedException("A test for a valid palindrome hasn't been written yet");
    }

    [Theory]
    [InlineData("grammar", false)]
    // Your new test case(s) should go here
    public void IsPalindrome_CalledWithText_ReturnsExpectedResult(string text, bool expectedResult)
    {
        var result = Challenges.IsPalindrome(text);
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(0, 0)]
    // Your new test case(s) should go here
    public void SumOfNumbersUpToN_CalledWithNonNegativeNumber_ReturnsExpectedSum(
        int n,
        int expectedSum
    )
    {
        var sum = Challenges.SumOfNumbersUpToN(n);
        sum.Should().Be(expectedSum);
    }

    [Theory]
    [InlineData("0", true)]
    [InlineData("123", true)]
    [InlineData("-123", true)]
    [InlineData("123.45", true)]
    [InlineData("-123.45", true)]
    [InlineData("123..45", false)]
    [InlineData("123.45.6", false)]
    [InlineData("hello", false)]
    public void IsNumeric_CalledWithText_ReturnsExpectedResult(string text, bool expectedResult)
    {
        throw new NotImplementedException("A test for IsNumeric hasn't been written yet");
    }

    public static readonly IEnumerable<object[]> SortedAndUnsortedIntArrays = new List<object[]>
    {
        new object[] { new[] { 1, 2, 3 }, true },
        // Your new test case(s) should go here
    };

    [Theory]
    [MemberData(nameof(SortedAndUnsortedIntArrays))]
    public void IsSorted_CalledWithIntArray_ReturnsExpectedResult(
        int[] numbers,
        bool expectedResult
    )
    {
        throw new NotImplementedException("A test for IsSorted hasn't been written yet");
    }

    [Theory]
    [InlineData("CSharp123", true)]
    // Your new test case(s) should go here
    public void TryLogin_CalledWithPasswordAttempt_ReturnsExpectedResult(
        string passwordAttempt,
        bool expectedResult
    )
    {
        throw new NotImplementedException("A test for TryLogin hasn't been written yet");
    }

    [Theory]
    [InlineData("yes", "yes", "You should visit the moon.")]
    // Your new test case(s) should go here
    public void ShouldVisitMoon_Called_OutputsExpectedMessage(
        string wantsToVisitMoon,
        string canAffordToVisitMoon,
        string expectedMessage
    )
    {
        throw new NotImplementedException("A test for ShouldVisitMoon hasn't been written yet");
    }
}
