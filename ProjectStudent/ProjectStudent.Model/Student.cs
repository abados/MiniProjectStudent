using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudent.Model
{
    public class Student
    {

        int id;
        public int Id { get { return id; } }

        int age;
        public int Age { get { return age; } }

        string name;
        public string Name { get { return name; } }

        string address;
        public string Address { get { return address; } }

        public Student(int id,int age, string name,string address)
        { 
            this.id = id;
            this.age = age;
            this.name = name;
            this.address = address;
        }
    }
}
