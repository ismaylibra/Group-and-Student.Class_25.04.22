using System;
using System.Collections.Generic;
using System.Text;

namespace Group_and_Student_classes
{
    class Group : Student
    {

        public string GroupNo;
        public byte GroupLimit;
        Student[] _students;
        public Group(string gnum, byte limit)
        {
            GroupNo = gnum;
            GroupLimit = limit;
            _students = new Student[0];
        }
        public Group()
        {

        }
        public void AddStudent(Student student)
        {
            if (GroupLimit > _students.Length)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Qrup artiq doludur");
            }
        }
        public void GetStudent()
        {
            Console.WriteLine($"Group Limit: {GroupLimit}");
            foreach (var students in _students)
            {
                Console.WriteLine($"Name: {students.Name}   Surname: {students.Surname}   Group Number: {GroupNo}");

            }
        }
    }
  
}

