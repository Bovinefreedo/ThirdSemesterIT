using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{

    public class BubbleSort
    {
        public static Func<Person[], Person[]> sortPeopleByName = ppl =>
            Sort(ppl, SortOnName!);

        public static Func<Person, Person, int> SortOnAge = (p1, p2) =>
            p1.Age - p2.Age > 0 ? 1 : p1.Age == p2.Age ? 0 : -1;

        public static Func<Person, Person, int> SortOnName = (p1, p2) =>
            p1.Name.CompareTo(p2.Name) > 0 ? 1 : p1.Age.CompareTo(p2.Age) == 0  ? 0 : -1;

        public static Func<Person, Person, int> SortOnPhone = (p1, p2) =>
            p1.Phone.CompareTo(p2.Phone) > 0 ? 1 : p1.Phone.CompareTo(p2.Phone) == 0 ? 0 : -1;

        // Bytter om på to elementer i et array
        private static void Swap(Person[] array, int i, int j)
        {
            Person temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Laver sortering på array med Bubble Sort. 
        // compareFn bruges til at sammeligne to personer med.
        public static Person[] Sort(Person[] array, Func<Person, Person, int> compareFn)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    // Laver en ombytning, hvis to personer står forkert sorteret
                    if (compareFn(array[j], array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
            return array;
        }
    }
}
