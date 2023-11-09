namespace Lesson4;

public class Friend
{
    public void IntroduceEveryoneToEachOther(string[] people)
    {
        for (var i = 0; i < people.Length - 1; i++)
        {
            for (var j = i + 1; j < people.Length; j++)
            {
                GiveIntroduction(people[i], people[j]);
            }
        }
    }

    public virtual void GiveIntroduction(string person1, string person2)
    {
        SayHello(person1);
        SayHello(person2);
        Console.WriteLine($"{person1}, this is {person2}. {person2}, this is {person1}.");
    }

    public virtual void SayHello(string person)
    {
        Console.WriteLine($"Hello, {person}!");
    }
}
