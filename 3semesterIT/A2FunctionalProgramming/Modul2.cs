using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdSemesterIT.A2FunctionalProgramming
{
    public class Modul2
    {
        public static Person[] people = new Person[]{
            new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
            new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
            new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
            new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
            new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
            new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
        };

        public static Func<Person[], int> totalAge = array =>
            array.Sum(x => x.Age);


        public static Func<Person[], string, int> containsName = (array, name) =>
            array.Sum(x => x.Name.Contains(name) ? 1 :0);


        public static Func<Person[],Person> oldestPerson = array =>
            array.MaxBy(x => x.Age)!;


        public static Func<Person[], string, Person> findByPhoneNumber = (array, phoneNumber) =>
            array.FirstOrDefault(x => x.Phone == phoneNumber)!;


        public static Func<Person[], int, Person[]> aboveAge = (array, age) =>
            array.Where(x => x.Age >= age).ToArray();

        public static Func<Person[], Person[]> removeNationCode = array => 
            array.Select(x =>new Person {
                Phone= x.Phone.Substring(3), 
                Name = x.Name,
                Age = x.Age}).ToArray();

        public static Func<Person[], int ,Person[]> youngerThan = (array, age) =>
            array.Where(x => x.Age < age ).ToArray();

        public static Func<string, string[], string> badWordIdentifier = (word, badWord) =>
            badWord.Contains(word) ? "REDACTED" : word;
        
        public static Func<string[], string[], string[]> badWordReplacer = (text, badwords) =>
            text.Select(x => badWordIdentifier(x, badwords)).ToArray();
    }
}
