using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //toàn bộ info bên trong là default:
            //chuỗi -> empty, số -> 0, bool -> false
            student.SetId("SEngu");
            student.SetName("Học ngu");
            student.SetYob(2004);
            student.SetGpa(3);
            //Console.WriteLine(student.ToString());
            Console.WriteLine(student);/// gọi thầm tên em
            //khi bạn quyết định in ra biến object, bên ca in ra đại chỉ con trỏ
            // bên java c# nó đi tìm hàm ToString() để chạy
            //JAVA: in ra mã băm của vùng ram nếu class mình làm không có hàm ToString(), đi gọi hàm của cha
            //C#: không in mã băm của vùng ram của class nếu clas mình không có hàm toString(), trả về Data type của vùng new - tình uống này trả về chữ student

            //vậy nếu mình cố tình sửa lại code ToString() được không -> được, thì mới gọi là override phủ quyết, qua mặt cha, cha ngồi đó, để ocn lo
            //một biến bất kì
            int yob = 2004;
            //ta muốn get value của nó, tên biến là đủ
            // xài tên biến là get(), get() là lấy thông tin
            //cw(yob); lấy value và in ra

            //ta muốn set value cho biến
            //tên biến = value;
            //yob = 2006; set value 2006 cho yob

            //bản thân 1 biến đã mang 2 ý nghĩa: get và set
            // có cần phải cái hàm bao hành động này lại hay k???
            
        }

    }
}
