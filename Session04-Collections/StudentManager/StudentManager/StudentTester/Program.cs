using StudentTester.Entities;
using StudentTester.Services;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet tuSE = new(500);
            Cabinet tuIA = new(100);

            tuSE.AddStudent("SE1", "An Nguyen", 2004, 6.8);
            tuSE.AddStudent("SE2", "Binh An", 2004, 8.6);
            tuSE.AddStudent(new Student() { Id = "SE3", Name = "Cuong oc cho", Yob = 2003, Gpa = 1 });
            tuIA.AddStudent("SE4", "Toi ngu ngoc", 2004, 10);

            Student e = new Student() { Id = "SE5", Name = "Thu 5 oc cho", Yob = 2003, Gpa = 1 };
            tuIA.AddStudent(e);

            Console.WriteLine("The list of ia Students");
            tuIA.PrintStudentList();

            Console.WriteLine("The list of SE Students");
            tuSE.PrintStudentList();

            //Đổi tên ku cường
            tuSE.UpdateStudent("SE3", "Negav anh trai sây gút bai", null, null);
            Console.WriteLine("After updateing SE3's Name");
            tuSE.PrintStudentList();
        }
    }
}
