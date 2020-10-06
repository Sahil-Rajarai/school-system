using System.Collections.Generic;
using SchoolSystem.interfaces;

namespace SchoolSystem
{
    public class Student:Person,IBusiness
    {
        public string Course { get; set; }
        DataManagement dataMgt;
        
        public Student() 
        {
            dataMgt = new DataManagement();
        }

        public Student AddStudent() 
        {
            return dataMgt.AddStudent(this);
        }
        public void DeleteStudent() 
        {
            dataMgt.DeleteStudent(this);
        }
        public Student UpdateStudent(Student updatedStudent) 
        {
            dataMgt.UpdateStudent(this, updatedStudent);
            return null;
        }
    }
}