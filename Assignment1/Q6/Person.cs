using System;

namespace Q6    // Working with multiple classes[inheritence]
{
    public class Person       // Base/Parent Class
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person()
        {
            this.Age = 24;
            this.Name = "Aakash";
        }
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}