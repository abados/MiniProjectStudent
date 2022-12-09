using ProjectStudent.DAL;
using ProjectStudent.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectStudent.Entities
{
    public class StudentsManager
    {
      
        public static void addToHashTableOfStudent(int id, int age,string name, string address)
        {
            Model.Student student = new Model.Student(id,age,name,address);
            MainManager.Instance.hashStudent.Add(student.Id, student);
        }

        public static void addToStudentDB(string id, string age, string name, string address)
        {
            SqlQuery.RunNonQuery($"insert into Students (ID, Name, Age, Address) values ('{id}', '{name}', '{age}', '{address}') ");
            
        }

        public static Student searchAndBringData(int id)
        {
            return (Student)MainManager.Instance.hashStudent[id];
        }

        public static void bringDBIntoHash(SqlDataReader reader)
        {
            MainManager.Instance.hashStudent.Clear();
           
           
            while (reader.Read())
            {
                Model.Student newStudent = new Model.Student(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1), reader.GetString(3));

                MainManager.Instance.hashStudent.Add(newStudent.Id, newStudent);
            }
           
        }

        public static void LoadStudents()
        {
            SqlQuery.RunCommand("select * from Students", bringDBIntoHash);
        }

    }
}
