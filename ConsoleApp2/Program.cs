using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void SaveToShowFile(Person somePerson)
        {
            FileStream fileStreamObject = new FileStream($@"C:\files\person.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStreamObject))
            {
                writer.WriteLine(@"{somePerson.fullName},{somePerson.age},{somePerson.age2}");
                SaveToAllShowsFile(somePerson.fullName);
            }
        }
        static void SaveToAllShowsFile(string showName)
        {
            FileStream fileStreamObject = new FileStream($@"C:\test\shows.txt", FileMode.Append);
            using (StreamReader reader = new StreamReader(fileStreamObject))
            {
                reader.ReadLine();
            }
        }
        static string GetPersonFromFile(string fileName)
        {
            FileStream fileStream = new FileStream($@"C:\test\{fileName}.txt", FileMode.Open);
            using(StreamReader reader = new StreamReader(fileStream))
            {
                return reader.ReadToEnd();
            }
        }
        static string GetPersonFromList(List<Person> pList, string name)
        {
            foreach (Person personItem in pList)
            {
                if (personItem.fullName==name)
                {
                   return $"{personItem.fullName},{personItem.age},{personItem.age2}";
                }
            }
            return "no person was found";
        }
        //List<Person> personsList = new List<Person>();
        //for (int i = 0; i < 6; i++)
        //{
        //    Person myPerson = new Person("jacob inggidou", 23, new List<int> { 34 });
        //    SaveToShowFile(myPerson);
        //    personsList.Add(myPerson);
        //}
        //string personDataFromFile = GetPersonFromFile(Console.ReadLine());
        //Console.WriteLine(personDataFromFile);
        //string result = GetPersonFromList(personsList, Console.ReadLine());
        //Console.WriteLine(result);
    }
}
