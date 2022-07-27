using System;

namespace Q6
{
    public class Register
    {
        protected List<Student> StudentsList = new();
        protected List<Teacher> TeachersList = new();

        public static void Main(string[] args)
        {
            // Create a Register
            Register reg = new();

            // Create students, set their name and age and add them to the Register.
            Student stud1 = new(23, "Alice");
            Student stud2 = new(24, "Bob");
            Student stud3 = new(25, "Clark");
            reg.StudentsList.Add(stud1);
            reg.StudentsList.Add(stud2);
            reg.StudentsList.Add(stud3);

            // Create teachers, set their name and age and subject to the Register.
            Teacher teach1 = new(34, "Jennifer");
            Teacher teach2 = new(34, "Winston");
            Teacher teach3 = new(34, "Charles");
            reg.TeachersList.Add(teach1);
            reg.TeachersList.Add(teach2);
            reg.TeachersList.Add(teach3);

            // Set Session for teachers
            teach1.SetSession("Programming", 2);
            teach2.SetSession("Maths", 1);
            teach3.SetSession("English", 2);
            Console.WriteLine();

            // Make students Attend Session.
            stud1.AttendSession(teach1);
            stud2.AttendSession(teach1);
            stud1.AttendSession(teach2);
            stud2.AttendSession(teach2);
            stud1.AttendSession(teach3);
            stud2.AttendSession(teach3);
            stud3.AttendSession(teach3);
            Console.WriteLine();

            // Display list of students for teachers.
            Console.WriteLine($"Below are the students for teacher {teach1.Name}");
            foreach (Student st in teach1.StudentsList)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine($"Below are the students for teacher {teach2.Name}");
            foreach (Student st in teach2.StudentsList)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine($"Below are the students for teacher {teach3.Name}");
            foreach (Student st in teach3.StudentsList)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine();

            // Display list of Teachers and their sessions.
            Console.WriteLine($"{teach1.Name} has a session of {teach1.Subject} for {teach1.Hours} hours");
            Console.WriteLine($"{teach2.Name} has a session of {teach2.Subject} for {teach2.Hours} hours");
            Console.WriteLine($"{teach3.Name} has a session of {teach3.Subject} for {teach3.Hours} hours");
        }
    }
}
