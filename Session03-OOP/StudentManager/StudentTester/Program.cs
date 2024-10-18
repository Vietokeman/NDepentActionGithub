using StudentTester.Entities;   //.* bên java
//~~ import java.util.Scanner;  //java.util.*

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentObjects();
        }
        static void CreateStudentObjects()
        {

            Student a = new Student("SE180672", "Viet", 2004, 8.5);
            // gọi cái phễu để đổ vào, lấp vào bên trong cái khuôn, để đúc 1 objject, 1 bức tượng
            // giống như đổ mực lên cái phooi đã được clone, để thành 1 CMND của bạn, của tôi, của ai...
            Student binh = new("SEhehe", "Binh", 2004, 8.7);

            var cuong = new Student("SEhuhu", "Cường lz", 2004, 3);
            //Student dung = new(8.9, 2005, "SEngungu", "Dung ngu");
            // khi gọi tham số hàm, phải gọi đúng thứ tự biến đã được xác định ở trên hàm. Constructor cũng là 1 hàm, hàm được biệt để clone vùng ram và fill thông tin của object, cái phễu nhận vật liệu.
            Student dung = new Student(gpa: 8.9, yob: 2006, id: "Ngu nhu heo", name: "Dung ngu xi");
            // kĩ thuật gọi hàm mà k theo thứ tự của biến, gọi lộn xộn thứ tự okie luôn miễn là chỉ ra được biến nào ứng với value nào qua kí hiệu tên biến: value.
            //Kĩ thuật này giúp ta linh hoạt trong cách gọi hàm
            //kĩ thuật này gọi là: Named-Argument
            //Gọi hàm đi kèm tên tham số

            //flex infor của 4 bạn

            //            var cuong = new Student("SEhuhu", "Cường lz", 2004, 3);
            //              nickname                object
            //Con người có xu hướng đặt tên gọi cho mọi thứ (Đơn giản & phức tập)
            //3.14 -> PI, 9.8 -> G, 300 -> price, total, c
            //10% 8% 0> discount, vat
            //{NTT, TB, 1994, NV TPHCM, HẢI TÚ} -> SẾP
            //CaSi sep = new CaSi(...)
            //Console.WriteLine("Việt's name: " + a.GetName());
            //Console.WriteLine("Bình's name: {0}" , binh.GetName());
            //Console.WriteLine($"Cường's name: {cuong.GetName()}");
            //Console.WriteLine("Dũng's name: {0}", dung.GetName());



            //Hỏi thông tin của từng bạn nào đó



            //Các sinh viên học hành chăm chỉ
            //Điểm trung bình được cập nhật
            a.SetGpa(10);
            a.FlexProfile();
            binh.FlexProfile();
            cuong.FlexProfile();
            dung.FlexProfile();
            Console.WriteLine($"Anh Việt giỏi quá => GPA: {a.GetGpa()}");


            //student s = new Student();
            Student s = a;// 2 chàng nhìn 1 nàng, 2 chàng cùng 1 tọa độ
            s.FlexProfile();

            s.SetGpa(67.89);
            s.FlexProfile();


            Student xxx = a;
            a.FlexProfile();

            //câu hỏi: điều gì sẽ diễn ra
            s = binh;
            s.FlexProfile();
            a.FlexProfile();

            a = binh;
            a.FlexProfile();
            s.FlexProfile();
            binh.FlexProfile();
            Console.WriteLine("3 Chàng 1 nàng");
            xxx.FlexProfile();

            //System.GC.Collect();dọn ram garbage collector, module trong runtime 
            // chuyên đi dọn dẹp vùng new mồ côi - k có biến trỏ đến        
        }
    }
}
