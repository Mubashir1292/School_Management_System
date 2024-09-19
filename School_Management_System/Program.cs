using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    class Person
    {
        public string name;
        public int age;
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual string GetDetails()
        {
            return $"Name {name} Age {age}";
        }
    }
    class Student : Person
    {
        public int grade;
        public Student(string name,int age,int grade) : base(name, age)
        {
            this.grade = grade;
        }
        public override string GetDetails()
        {
            return $"{base.GetDetails()} Grade {grade}";
        }
        public void Study()
        {
            Console.WriteLine($"What do you do {name}");
            string work = Console.ReadLine();       
            Console.WriteLine("Well!Thats Great...."+work);
        }
    }
    class Teacher : Person
    {
        public int year_of_experience;
        public string subject;
        public Teacher(string name,int age,int year_of_experience,string subject) : base(name, age)
        {
            this.year_of_experience = year_of_experience;
            this.subject = subject;
        }
        public override string GetDetails()
        {
            return $"{base.GetDetails()} Year of Experience {year_of_experience} Subject {subject}";
        }
        public void Teach()
        {
            Console.WriteLine("What is Today's Topic");
            string topicName = Console.ReadLine();
            Console.WriteLine($"{topicName} of this {subject} submit is very tough \t Are you Agree with me");
            string yesNo = Console.ReadLine();
            Console.WriteLine("Great");
            /*Console.WriteLine($"Sir {name} Teaches the {subject} Subject Most and having {year_of_experience} of Experience and he is {age} year's old");
*/
        }
    }
    class Employee : Person
    {
        public int salary;
        public int yearsOfEmployment;
        public Employee(int salary,int yearsOfExperience,string name,int age) : base(name, age)
        {
            this.salary = salary;
            this.yearsOfEmployment = yearsOfExperience;
        }
        public override string GetDetails()
        {
            return $"{base.GetDetails()} Salary {salary} Years Of Expereince {yearsOfEmployment}";
        }
        public void AnyComplaints()
        {
            Console.WriteLine("Is There any Complain about your company?");
            string complaint = Console.ReadLine();
            if (complaint == "yes")
            {
                Console.WriteLine("Please Enter your complain...");
                string complainText = Console.ReadLine();
                Console.WriteLine($"Your complain is registed {complainText},We will start working on it soon...");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(0, 0, "Mubashir Liaqat", 21);
            Console.WriteLine(employee.GetDetails());
            Console.ReadKey();
            /*try
            {
                Console.WriteLine("Enter your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your Age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Grade");
                int grade = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(name, age, grade);
                Console.WriteLine(student.GetDetails());
                student.Study();
                // Teacher's Data
                Console.WriteLine("Enter your Name");
                string tName = Console.ReadLine();
                Console.WriteLine("Enter your Age");
                int tAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Subject Name");
                string subject = Console.ReadLine();
                Console.WriteLine("Enter the Years of Experience");
                int years = Convert.ToInt32(Console.ReadLine());
                Teacher teacher = new Teacher(tName, tAge, years, subject);
                Console.WriteLine(teacher.GetDetails());
                teacher.Teach();
                Console.ReadKey();
            }
            catch (Exception cp)
            {
                Console.WriteLine(cp.Message);
            }*/
        }
    }
}
