using System.Collections.Generic;

namespace SchoolSystem.interfaces
{
    public interface IData
    {
        Student AddStudent(Student student);
        // Student GetStudentById(string studentId);
        void DeleteStudent(Student studentToDelete);
        Student UpdateStudent(Student oldStudent, Student updatedStudent);
        // List<Student> GetAllStudents();
    }
}