using StudentTester.Entites;
using StudentTesterV2.Services;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentRepo = new Cabinet<Student>(500);
            var lecturerRepo = new Cabinet<Lecturer>(500);
            studentRepo.Add(new Student() { Id = "se1", Name = "An dep trai", Yob = 2004, Gpa = 11.1 });
            studentRepo.Add(new Student() { Id = "se2", Name = "Binh be", Yob = 2014, Gpa = 1.1 });
            studentRepo.Add(new Student() { Id = "se3", Name = "Thinh san", Yob = 2007, Gpa = 2.2 });
            lecturerRepo.Add(new Lecturer() { Id = "L1", Name = "Thay giao an", Yob = 1999, Salary = 100000.0 });
            lecturerRepo.Add(new Lecturer() { Id = "L2", Name = "Co giao viet", Yob = 1960, Salary = 5000.0 });
            lecturerRepo.Add(new Lecturer() { Id = "L3", Name = "Thay giao duong", Yob = 1961, Salary = 10000.0 });
            studentRepo.PrintList();
            Console.WriteLine();
            lecturerRepo.PrintList();
            Console.WriteLine();
            studentRepo.Delete(i => i.Id.ToLower() == "se2");
            lecturerRepo.Delete(i => i.Id.ToLower() == "l2");
            studentRepo.PrintList();
            Console.WriteLine();
            lecturerRepo.PrintList();
            Console.WriteLine();
            studentRepo.Update(i => i.Id.ToLower() == "se3", new Student() { Id = "se3", Name = "Thinh san", Yob = 2017, Gpa = 2.2 });
            lecturerRepo.Update(i => i.Id.ToLower() == "l3", new Lecturer() { Id = "L3", Name = null, Yob = 22, Salary = 10000.0 });
            studentRepo.PrintList();
            Console.WriteLine();
            lecturerRepo.PrintList();
            Console.ReadKey();
        }
    }
}
