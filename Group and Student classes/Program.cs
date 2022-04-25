using System;

namespace Group_and_Student_classes
{
    class Program
    {
        static void Main(string[] args)
            
        { Group group = new Group("p324", 3);
            Student student1 = new Student("Ismayil", "Ibrahimli");
            Student student2 = new Student("Elshen", "Aliyev");
            Student student3 = new Student("Xelil", "Xelilbeyli");
            Student student4 = new Student("Ilham", "Aliyev");
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.GetStudent();
          
        }
    }
}
