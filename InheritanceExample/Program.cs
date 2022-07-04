using System;

namespace InheritanceExample
{

    class Person
    {
        public string Name { get; set; } 
        public string SurName { get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
            Console.WriteLine("Person object created");
        }

        public virtual void Intro()
        {
            Console.WriteLine($"name: {this.Name} surname: {this.SurName}");
            
        }
    }

    class Student: Person
    {
        public string StudentNumber { get; set; }
        public Student(string name, string surname, string studentNumber) : base(name, surname)
        {
            this.StudentNumber = studentNumber;
            Console.WriteLine("Student object created");
            StudentNumber = studentNumber;
        }
        public override void Intro()
        {
            Console.WriteLine($"name: {this.Name} surname: {this.SurName} student number: {this.StudentNumber}");
        }
    }

    class Teacher : Person
    {
        public string Branch { get; set; }
        public Teacher(string name, string surname, string branch) : base(name, surname)
        {
            this.Branch = branch;
        }

        public void Teach()
        {
            Console.WriteLine("I am teaching...");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person("Jack","Jones");
            var s = new Student("Calvin","Klein","100");
            var t = new Teacher("Eren", "Sapci", "CS");

            t.Intro();
            t.Teach();


        }
    }
}
