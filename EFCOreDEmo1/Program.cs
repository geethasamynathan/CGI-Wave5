using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore_Demo1
{
    class Program
    {
       static SchoolContext context;
        static void Main(string[] args)
        {
          //  UpdateStudent();
            GetAllStudents();
            Console.WriteLine("\n\n Enter the id the student to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            DeleteStudent(id);
            Console.WriteLine(" \n\n After deleting the given student our records are below");
            GetAllStudents();
        }
      public void  AddNewStudent()
        {
            context = new SchoolContext();
            Student stu = new Student();
            stu.Name = "Geetha";
            context.Students.Add(stu);
            context.SaveChanges();
        }
        public static void GetAllStudents()
        {
            context = new SchoolContext();
               List<Student> studentList = context.Students.ToList();
          
            foreach (var item in studentList)
            {
                Console.WriteLine($" Id : {item.StudentId} \t Name :{item.Name}");
            }
        }
        public static void UpdateStudent()
        {
            context = new SchoolContext();
            Student student = context.Students.FirstOrDefault(s => s.StudentId == 1);
            student.Name = "Yamuna";
            context.SaveChanges();
        }
        public static void DeleteStudent(int id)
        {
            context = new SchoolContext();
            Student student = context.Students.FirstOrDefault(s => s.StudentId == id);
               context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
