using System.Collections.Generic;
using System;
using SchoolSystem.interfaces;

namespace SchoolSystem
{
    public class DataManagement:IData
    {
        public static List<Student> AllStudents = new List<Student>();

        public static List<Student> GetAllStudents() 
        {
            return AllStudents;
        }
        public Student AddStudent(Student student) 
        {   
            // student.PersonId = Guid.NewGuid().ToString().Substring(0,8);
            AllStudents.Add(student);
            return student;
        }
        public static Student GetStudentById(string studentId) 
        {
            return AllStudents.Find(student => student.PersonId == studentId);
        }
        public void DeleteStudent(Student studentToDelete) 
        {
            Console.WriteLine("studentToDelete " + studentToDelete.Name);
            AllStudents.Remove(studentToDelete);
        }
        public Student UpdateStudent(Student oldStudent, Student newStudent) 
        {
            oldStudent.Name = newStudent.Name;
            oldStudent.Sex = newStudent.Sex;
            oldStudent.Age = newStudent.Age;
            oldStudent.Course = newStudent.Course;

            return null;
        }
    }
}