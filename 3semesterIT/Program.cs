using System.Globalization;
using ThirdSemesterIT.A1Recurssion;
using ThirdSemesterIT.A2FunctionalProgramming;
using ThirdSemesterIT.B1Leetcode;

//for (int i = 0; i< 30; i++)
//    Console.WriteLine(NPotensFunctional.nPotens(2,i));

//Person[] people = Modul2.youngerThan(Modul2.people, 30);

//Console.Write(string.Join(" ", newWords));

//Person[] people = BubbleSort.Sort(Modul2.people, BubbleSort.SortOnName);

//foreach (Person person in people)
//{
//    Console.WriteLine($"{person.Name}, Age: {person.Age}, PhoneNumber {person.Phone}");
//}

var result = Q126WordLadderII.FindLadders ("hit","cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });

foreach (var item in result)
{
    Console.WriteLine("");
    foreach (var word in item) { 
        Console.Write($"{word}, ");
    }
}

result = Q126WordLadderII.FindLadders("red", "tax", new List<string>() { "ted", "tex", "red", "tax", "tad", "den", "rex", "pee" });

foreach (var item in result)
{
    Console.WriteLine("");
    foreach (var word in item)
    {
        Console.Write($"{word}, ");
    }
}