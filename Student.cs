using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    public class Student
    {
        public Student(Student student)
        {
            this.FirstName = student.FirstName;
            this.LastName = student.LastName;
            this.MiddleName = student.MiddleName;
            this.Age= student.Age;
            this.id = student.id;
            this.Group = student.Group;
        }
        public Student(string FirstName, string MiddleName, string LastName, int Group)
        {
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;   
            this.LastName = LastName;
            this.Group = Group;

        }

        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        
        private string FirstName;
        private string MiddleName;
        private string LastName;
        public int Age;
        public Guid id;
        public int Group;

        public void Print()
        {

            Console.WriteLine($"Фамилия {LastName}");
            Console.WriteLine($"Имя {FirstName}");
            Console.WriteLine($"Отчество {MiddleName}");
            Console.WriteLine($"Возраст {Age}");
            Console.WriteLine($"Уникальный Id {id}");
            Console.WriteLine($"Группа {Group}");
        }
        

    }
}
