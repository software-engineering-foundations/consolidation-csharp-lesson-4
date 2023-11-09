# Lesson 4 Independent Challenges

Before starting the challenges, make sure you have CSharpier and Husky installed:

```
dotnet tool install --global csharpier
dotnet tool install --global husky
```

Finally, run `husky install` at the root of the repository.

## Challenge 1: `IsPalindrome` and `IsPalindrome_CalledWithInvalidPalindrome_ReturnsFalse` (5 points)

A method called `IsPalindrome` has been partially written for you. An example test called `IsPalindrome_CalledWithInvalidPalindrome_ReturnsFalse` has also been written, which already passes and can be used as an example. You need to complete the test called `IsPalindrome_CalledWithValidPalindrome_ReturnsTrue` (which should fail at first) and then add a suitable implementation of `IsPalindrome` to make your new test pass. Note that the existing test, `IsPalindrome_CalledWithInvalidPalindrome_ReturnsFalse`, should not break.

A palindrome is a piece of text which reads the same forwards as it does backwards. Your `IsPalindrome` method should return a boolean value (`true` or `false`) to indicate whether the given text is a palindrome.

## Challenge 2: `IsPalindrome` and `IsPalindrome_CalledWithText_ReturnsExpectedResult` (5 points)

An improved test for `IsPalindrome` has been written called `IsPalindrome_CalledWithText_ReturnsExpectedResult`. It is just missing a valid palindrome test case: the invalid palindrome test case has already been added, along with the test implementation and your method implementation from the previous challenge. You should add a suitable valid palindrome test case in the right location.

## Challenge 3: `SumOfNumbersUpToN` and `test_sum_of_numbers_up_to_n` (10 points)

A method called `SumOfNumbersUpToN` and a test called `SumOfNumbersUpToN_CalledWithNonNegativeNumber_ReturnsExpectedSum` have been partially written for you. You need to add at least one new test case, and add a suitable implementation of `SumOfNumbersUpToN` to make your new test case(s) pass.

Your `SumOfNumbersUpToN` method should return the total of all the integers from 0 to `n` inclusive. You may assume that `n` will be non-negative.

## Challenge 4: `IsNumeric` and `IsNumeric_CalledWithText_ReturnsExpectedResult` (10 points)

A method called `IsNumeric` has been partially written for you, and some test cases have been provided for a test called `IsNumeric_CalledWithText_ReturnsExpectedResult`. You need to implement the test itself as well as the method.

Your `IsNumeric` method should return a boolean value (`true` or `false`) to indicate whether the given text can be converted to a double without error.

## Challenge 5: `IsSorted` and `IsSorted_CalledWithIntArray_ReturnsExpectedResult` (20 points)

A method called `IsSorted` and a test called `IsSorted_CalledWithIntArray_ReturnsExpectedResult` have been partially written for you. You need to provide some test cases and implement the test and the method.

Your `IsSorted` method should return a boolean value (`true` or `false`) to indicate whether the given array of numbers is sorted in ascending order (each number should be greater than or equal to the one before it).

## Challenge 6: `TryLogin` and `TryLogin_CalledWithPasswordAttempt_ReturnsExpectedResult` (20 points)

A method called `TryLogin` and a test called `TryLogin_CalledWithPasswordAttempt_ReturnsExpectedResult` have been partially written for you. You need to provide some test cases and implement the test and the method.

Your `TryLogin` method should ask the user for a single response: what the password is. If they type the correct password (which is `CSharp123`), the method should return `true`. Otherwise, the method should return `false`.

**Note: you may find it helpful to look at the tests for the lesson 2 challenges for a reminder of how to provide input for the `Console.ReadLine` method.**

## Challenge 7: `ShouldVisitMoon` and `ShouldVisitMoon_Called_OutputsExpectedMessage` (30 points)

A method called `ShouldVisitMoon` and a test called `ShouldVisitMoon_Called_OutputsExpectedMessage` have been partially written for you. You need to provide some test cases and implement the test and the method.

Your `ShouldVisitMoon` method should firstly ask the user for a single response: whether they would like to visit the moon. If their response is the exact word `yes`, ask them a further question: whether they can afford to visit the moon. If their response is the exact word `yes` again, output the following exact text:

```
You should visit the moon.
```

Otherwise, if their response to the second question is the exact word `no`, output the following exact text instead:

```
You shouldn't visit the moon if you can't afford to.
```

Otherwise, if their response to the second question matches neither word, output the following exact text:

```
I'm not sure whether you should visit the moon - it depends whether you can afford to.
```

Back to the original question, if their response to whether they want to visit the moon is the exact word `no`, output the following exact text:

```
You shouldn't visit the moon if you don't want to.
```

Finally, if their response to the original question was neither `yes` nor `no`, output the following exact text:

```
I'm not sure whether you should visit the moon - it depends whether you want to.
```

**Note: you may find it helpful to look at the tests for the lesson 2 challenges for a reminder of how to provide input for the `Console.ReadLine` method and how to catch the output of the `Console.WriteLine` method.**

## Bonus challenge: `Friend`

A (non-static) class called `Friend` with three methods called `SayHello`, `GiveIntroduction` and `IntroduceEveryoneToEachOther` has been written for you. These methods are as yet untested, and it is your job to fix this.

You should write tests for the following behaviours:
- `IntroduceEveryoneToEachOther` should call `GiveIntroduction` the correct number of times
- `GiveIntroduction` should call `SayHello` twice with the right arguments and output the correct introductory message
- `SayHello` should output the correct greeting message

You should use the `FakeItEasy` testing package to mock and count function calls where appropriate. If you need some hints, each of the following code snippets may be useful:

```csharp
var friend = A.Fake<Friend>();
A.CallTo(() => friend.GiveIntroduction(A<string>.Ignored), A<string>.Ignored)).MustHaveHappenedANumberOfTimesMatching(number => number == count);
A.CallTo(() => friend.GiveIntroduction(A<string>.Ignored), A<string>.Ignored)).CallsBaseMethod();
A.CallTo(() => friend.SayHello(person1)).MustHaveHappenedOnceExactly();
```
