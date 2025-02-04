using System.Globalization;
using ThirdSemesterIT.A1Recurssion;
using ThirdSemesterIT.A2FunctionalProgramming;
using ThirdSemesterIT.B1Leetcode;

//for (int i = 0; i< 30; i++)
//    Console.WriteLine(NPotensFunctional.nPotens(2,i));

//Person[] people = Modul2.youngerThan(Modul2.people, 30);

//string[] badwords = new string[] { "vasketøjet", "regnvejr", "email", "forsinket", "tidligt" };
//string[] words = new string[] { "Jeg", "vil", "stå", "tidligt", "op", "og", "gøre", "noget", "ved", "vasketøjet", "jeg", "håber", "det", "ikke", "bliver", "regnvejr", "ellers", "sender", "jeg", "en", "email" };

//string[] newWords = Modul2.badWordReplacer(words, badwords);

//Console.Write(string.Join(" ", newWords));

Person[] people = BubbleSort.Sort(Modul2.people, BubbleSort.SortOnName);

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name}, Age: {person.Age}, PhoneNumber {person.Phone}");
}
