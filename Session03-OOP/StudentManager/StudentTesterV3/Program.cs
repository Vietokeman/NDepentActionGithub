using StudentTesterV3.Entities;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student("SE1", "An nguyễn", 2004, 9);
            Student an1 = new Student();
            Student an2 = new ();
            Student an3 = new ("SE1", "An nguyễn", 2004, 9);
            var an4 = new Student();// type inference 

            //hỏi an đầu tiên, full thông tin
            //hỏi an đầu tiên, chỉ hỏi tên (gọi GET() ) style mới
            Console.WriteLine("An full into: " + an); //gọi thầm tên em
            Console.WriteLine("An name: " + an.Name); // GỌI THẦM TÊN EM


            //BÌNH

            var binh = new Student(yob: 2004, id: "SE123", name: "Binh Le", gpa: 8);
            Console.WriteLine($"Binh full info: {binh}"); // goi tham ten em,

            //Chấn động sử dụng get set ngay khi new

            var cuong = new Student();
            Console.WriteLine("Cuong info at first: {0}", cuong); // goi tham ten em
            //Dien info qua con duong set() kieu mlem
            //.setName() .setYob()
            cuong.Id = "se2";
            cuong.Name = "Stupid";
            cuong.Gpa = 8;
            cuong.Yob = 2020;
            Console.WriteLine("Cuong info at second: {0}", cuong); // goi tham ten em


            //chấn động vãi ò, thật sự - new và set viết gộp
            var dung = new Student()
            {
                Id = "Se4",
                Name = "Dung pham",
                Yob = 2004,
                Gpa = 0
            };

            //new và set goi jcùng lúc thay vì gọi riêng
            //cú pháp này được gọi là: object intialization
            //tạo object đồng thời gán luôn các backing field qua ngả Property
            Console.WriteLine("Dũng full info: " + dung);
        }
    }
}
