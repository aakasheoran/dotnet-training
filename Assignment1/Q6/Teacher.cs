using System;
using System.Collections.Generic;

namespace Q6
{
    public class Teacher : Person      // Child/Derived class of Person
    {
        public string? Subject { get; set; }
        public int Hours { get; set; }
        public List<Student> StudentsList = new();
        public Teacher() : base(){ }
        public Teacher(int age, string name) : base(age, name) { }
        public void SetSession(string subject, int hours)
        {
            this.Subject = subject;
            this.Hours = hours;
            Console.WriteLine($"Session Begins for {subject}");
        }
    }
}
