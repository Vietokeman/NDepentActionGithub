using StudentTester.Entites;
using StudentTesterV2.Services;

namespace StudentTesterV3
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, };//5 gia tri int nhu nhau
            int[] b = { 5, 10, 15, 20, 25, 30, 35, 40, };//8 bien int, 8 value
            a = b; //2 chàng 1 nàng, mảng cũ của a gòm 1 2 3 4 5 bị mồ côi, bị CTMTĐT dọn dẹp, bộ gom rác của runtime

            Console.WriteLine("a[0]: " + a[0]);//5
            Console.WriteLine($"a's size: {a.Length}");//8

            //Tên mảng, tên biến object đưa qua tham số hàm, chẳng qua cũng là
            //2 chàng 1 nàng trỏ cùng luôn
            //voi F(Student[] a) cũng chính là mai mốt a = trỏ vào cùng mảng đauw ào hàm

            //cho tao trỏ với không phải đưa vào!!!
            //search trả về object, không phải, trỏ vào vùng new tim thấy
            //mảng đã xin không thay đổi kích thước được.
            //muốn thay đổi, trỏ mảng mới với kích thước mới

            a = new int[500];
            //a trỏ vào mảng mới 5000 biến int bằng 0 default


            //hạn chế của mảng
            //fix kích thước
            // đổi kích thước là sang sang mảng khác.
            //phải đi kèm biến count, phá count là phá mảng
            //collections trong java, c# giải quyết các hạn chế này !!!
            //java:
            //C# giống và khác
            // collections trong java và c# đều là những dạng class
            //giống như cái cabinet mình đã viết, tức là sinh ra những class này để chứa nhiều object
            //nhưng nó linh hoạt hơn mảng, co giãn về kích thước, muốn thêm thì nới, muốn bớt thì thu hẹp
            //đích đến chứa nhiều object

            //99% các class này được thiết kế để chứa nhiều object, vì vậy nó phải loose coupling, tức là nó hầu hết là generic
            //muốn xài nó phải nói rằng chứ object gì
            // tức là <???> <data type muốn chứa gì !!!!?
        }
        static void PlayWithGeneric()
        {
            //MUA TỦ HỒ SƠ SINH VIÊN VÀ HỒ SƠ GV, MỖI NHÓM 1 TỦ
            //JAVA
            //ARRAYLIST<STUDENT> LIST = NEW ARRAYLIST<STUDENT();

            Cabinet<Student> arr = new Cabinet<Student>(500);
            Cabinet<Lecturer> tuGV = new Cabinet<Lecturer>(500);

            arr.Add(new Student() { Id = "SE1", Name = "Viet cute" });
            arr.Add(new Student() { Id = "SE2", Name = "Viet De Thuong" });
            //Hậu trường hàm: _arr[count] = new Student() {} ở trên
            //                              new trực tiếp

            //new lẻ trước đưa hàm vào sau
            Student s = new Student() { Id = "SE3", Name = "Viet vippro", Gpa = 8386, Yob = 2004 };

            arr.Add(s);
            //hậu trường _arr[count] = s = newbên ngoài - 2 chàng 1 nàng

            // biến object này bằng biến object kia nghĩa là truyền thái y style tham chiếu, 2 chàng 1 nàng


            arr.PrintList();
        }
    }
}
