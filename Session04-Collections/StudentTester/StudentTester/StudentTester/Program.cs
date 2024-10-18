using StudentTester.Entites;
using StudentTester.Services;
using System.Text;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cabinet tuSE = new(500);
            Cabinet tuIA = new(400);
            tuSE.AddStudent(new Student() { Id = "se1", Name = "an", Yob = 2004, Gpa = 11.1 });
            tuSE.AddStudent(new Student() { Id = "se2", Name = "anh", Yob = 2004, Gpa = 6.1 });
            tuSE.AddStudent(new Student() { Id = "se3", Name = "binn", Yob = 2004, Gpa = 1.1 });
            tuIA.AddStudent("IA1", "Viet", 2003, 2.2);
            tuIA.AddStudent("IA2", "Thinh", 2002, 2.2);
            tuIA.AddStudent("IA3", "Dung", 2006, 2.2);
            tuIA.DeleteStudent("IA2");
            tuSE.DeleteStudent("SE2");
            Console.WriteLine("The list of SE Students");
            tuSE.PrintStudentList();
            Console.WriteLine("The list of IA Students");
            tuIA.PrintStudentList();

            //doi ten cu binh thanh negav
            tuSE.UpdateStudent("se3", null, null, null);
            Console.WriteLine("AFTER UPDATING SE3 NAME");
            tuSE.PrintStudentList();

            LecTurerCabinet tuL = new(500);
            tuL.AddLecturer(new Lecturer()
            {
                Id = "L1",
                Name = "QuocAn",
                Yob = 2004,
                Salary = 10000.20
            });
            tuL.PrintLecturerList();

            Console.ReadKey();
        }
    }
}
