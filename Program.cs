using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Riyaz";
            s.Age = 13;
            s.Sex = "M";
            s.Course = "Big Data";
            s.PersonId = "1";
            s.AddStudent();

            Student b = new Student();
            b.Name = "Thiago";
            b.Age = 15;
            b.Sex = "F";
            b.Course = "Big Data 2";
            b.PersonId = "2";
            b.AddStudent();

            Student c = new Student();
            c.Name = "Sadio";
            c.Age = 11;
            c.Sex = "F";
            c.Course = "Big Data 3";
            c.PersonId = "3";
            c.AddStudent();

            while(true)
            {
                Console.WriteLine("1: Add a student");
                Console.WriteLine("2: Get a student by Id");
                Console.WriteLine("3: Update details of a student");
                Console.WriteLine("4: Delete a student");
                Console.WriteLine("5: Get all students");
                Console.WriteLine("6: EXIT");
                Console.WriteLine("Select the number of your choice: ");
                string options = Console.ReadLine();
                string studentId;
                Student student;
                
                switch (options)
                {
                    case "1":
                        student = GetStudent();
                        student.AddStudent();
                        break;

                    case "2":
                        Console.WriteLine("Enter Student Id ");
                        studentId = Console.ReadLine();
                        student = DataManagement.GetStudentById(studentId);
                        Console.WriteLine("Student Name:" + student.Name);
                        break; 

                    case "3":
                        Console.WriteLine("Enter Student Id ");
                        studentId = Console.ReadLine();
                        student = DataManagement.GetStudentById(studentId);
                        Console.WriteLine("Student Name:" + student.Name);
                        Console.WriteLine("Enter new details ");
                        Student updatedStudent = GetStudent();
                        student.UpdateStudent(updatedStudent);
                        break; 

                    case "4":
                        Console.WriteLine("Enter Student Id ");
                        studentId = Console.ReadLine();
                        student = DataManagement.GetStudentById(studentId);
                        student.DeleteStudent();
                        break;

                    case "5":
                        List<Student> students = DataManagement.GetAllStudents();
                        
                        foreach(Student item in students) 
                        {
                            Console.WriteLine(item.PersonId + " " + item.Name);
                        }

                        break;
                        
                    case "6":
                        Environment.Exit(0);
                        break;

                    default: 
                        Console.WriteLine("Invalid input. Try again");
                        break;
                }
            }
        }
        public static Student GetStudent() 
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sex: ");
            string sex = Console.ReadLine();

            Console.WriteLine("Enter Course: ");
            string course = Console.ReadLine();

            Student student = new Student();
            student.Name = name;
            student.Age = age;
            student.Sex = sex;
            student.Course = course;

            return student;
        }
    }
}
