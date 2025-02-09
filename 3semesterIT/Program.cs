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

Q2349NumberContainers containers = new Q2349NumberContainers();

Console.WriteLine(containers.Find(10));
containers.Change(2, 10);
containers.Change(1, 10);
containers.Change(3, 10);
containers.Change(5, 10);
Console.WriteLine(containers.Find(10));
containers.Change(1, 20);
Console.WriteLine(containers.Find(10));
