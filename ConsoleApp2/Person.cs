using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string fullName;
        public int age;
        public int age2;
        public List<int> sizesList;
        public Person(string _fullName, int _age, List<int> _sizesList)
        {
            this.fullName = _fullName;
            this.age = _age;
            this.sizesList = _sizesList;
        }
        public Person() { }
        public int CompareTo(object per)
        {
            Person person = (Person)per;
            if (this.age > person.age) return 1;
            if (this.age < person.age) return -1;
            return 0;
        }
    }
}
