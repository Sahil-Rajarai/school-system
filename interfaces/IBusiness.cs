using System.Collections.Generic;


namespace SchoolSystem.interfaces
{
    public interface IBusiness
    {
        Student AddStudent();
        // Student GetStudentById(string studentId);
        void DeleteStudent();
        Student UpdateStudent(Student student);
        // List<Student> GetAllStudents();
    
    }
}