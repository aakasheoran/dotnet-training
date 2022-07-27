using System;

namespace Q6
{
    public class Student: Person        // Child/Derived Class of Person
    {
        public Student():base() { }
        public Student(int age, string name):base(age, name) { }
        public void AttendSession(Teacher t) {
            Console.WriteLine($"{this.Name} is going to attend {t.Subject} class");
            t.StudentsList.Add(this);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{this.Name} is {this.Age} years old");
        }
    }
}
