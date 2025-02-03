using System.Globalization;
using ThirdSemesterIT.A1Recurssion;
using ThirdSemesterIT.A2FunctionalProgramming;
using ThirdSemesterIT.B1Leetcode;

//Q475Heaters heaters = new Q475Heaters();

//int[] house = new int[30000];
//int[] heater = new int[30000];

//for (int i = 0; i < 30000; i++)
//{
//    house[i] = i + 1;
//    heater[i] = i + 1;
//}
//house[29999] = 2999;
//heater[29999] = 2999;

//Console.WriteLine(heaters.FindRadius(house, heater));

//Q5LongestPalindromicSubstring subPal = new();

//Console.WriteLine(subPal.LongestPalindrome("gtattarrattatg"));

//int[] nums = new int[1000];

//for (int i = 0; i < nums.Length; i++)
//{
//    nums[i] = Random.Shared.Next(0, 500);
//}

//nums = FunctionalQuickSort.quickSortFuctional(nums);

//foreach (int i in nums) { 
//    Console.WriteLine(i);
//}

//for (int i = 0; i< 30; i++)
//    Console.WriteLine(NPotensFunctional.nPotens(2,i));

//Person[] people = Modul2.youngerThan(Modul2.people, 30);

//string[] badwords = new string[] { "vasketøjet", "regnvejr", "email", "forsinket", "tidligt" };
//string[] words = new string[] { "Jeg", "vil", "stå", "tideligt", "op", "og", "gøre", "noget", "ved", "vasketøjet", "jeg", "håber", "det", "ikke", "bliver", "regnvejr", "ellers", "sender", "jeg", "en", "email" };

//string[] newWords = Modul2.badWordReplacer(words, badwords);

//Console.Write(string.Join(" ", newWords));

Person[] people = BubbleSort.sortPeopleByName(Modul2.people);

foreach (Person person in people) { 
    Console.WriteLine($"{person.Name}, Age: {person.Age}, PhoneNumber {person.Phone}");
}