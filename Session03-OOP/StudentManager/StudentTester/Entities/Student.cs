
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//~       java.util
namespace StudentTester.Entities
{
    public class Student
    {
        private string _id;    //ID     :............
        private string _name;  //NAME   :............
        private int _yob;      //YOB    :............
        private double _gpa;   //
        //CLASS NHư 1 cái khuôn, template, form, biểu mẫu (để điền vào), blue-prrint ( dàn khung, bản phác thảo, bản thiết kê)
        // Là tên gọi chung cho 1 nhóm objject chia sẻ chung nhiều đặc tính và hành vi(FIELDS, BEHAVIOR/METHOD)

        //ĐỂ CÓ 1 OBJECT, ĐỂ CÓ 1 ĐỐI TƯỢNG, 1 HỒ SƠ SINH VIÊN NHẬP HỌC, TA PHẢI ĐIỀN VÀO FORM Ở TRÊN, TA PHẢI PHOTO RA 1 FORM TRẮNG - NEW(CLONE, PHOTO)
        //SAU ĐÓ TA FILL INFO, ĐỔ INFO VÀO (THAM SỐ HÀM)
        //FILL VÀO ĐỂ TẠO RA OBJECT - CONSTRUCT/CONSTRUCTOR(THAM SỐ VẬT LIỆU ĐƯA VÀO)_
        //new           Student             (....)
        //clone form    gọi phễu
        //xin ram       nhận vật liệu       vật liệu đưa vào

        //object này đặt tên là gì? Student tèo = , Student tí =
        //Constructor để đúc object
        //Các hàm Get() Set() ToString() ~ FlexProfile()

        //phễu
        public Student(string id, string name, int yob, double gpa) 
        {
            _id = id;
            _name = name; // không cần xài this. vì không có sự nhầm lẫn tỏng biến đầu vào và đặc tính của object
            _yob = yob;
            _gpa = gpa;
        }

        //Các hàm truyển thống trong java here!!! 100 giống
        public void FlexProfile() => Console.WriteLine($"ID : {_id} | Name : {_name} | Yob : {_yob} | GPA : {_gpa}");

        //Console.Write($"ID: {_id}" );
        //Console.Write(", NAME: " + _name);
        //Console.Write(", yob: " + _yob);
        //Console.WriteLine(", gpa: " + _gpa);

        // object được sản xuất, được tạo ra, tức là đã đưuọc đổ info vào
        // giống như bạn vào ngân hàng, làm phiếu rút tiền, điền phiếu rút tiền, điền xong bạn ngắm nghía coi câu chữ rõ chưa, gọi là GET() info
        //Tôi biết bạn có tên, nhưng tên đang private
        //GETNAME() -> return trả về name

        public string GetName() => _name;
        public double GetGpa() => _gpa;
        public int GetAge() => 2024-_yob; //return 2024 - _yob
        //harđe-code trong code có những giá trị cố định, con số cố định
        //gọi class rồi gọi hàm lấy ngày giờ hệ thống - _yob



        //Đổi màn hình của ĐT, Đời avatar cover của tài khoàn mxh
        //Cần chuẩn bị 1 cái hình
        //Nhấn nút, thay thế khung-hình = hình mới chuẩn bị
        //Đổi nền(Hình mới)    Set, Setting, Setter
        //{
        //   khung-hinh-cu = hinh-moi;
        //}

        //Setting khong tạo ra object mới mà chỉ là tinh chỉnh chỉnh sửa object cũ đang có
        // tui bạn đổ bình mực lên tay, ko phải mực -> màu da mới được thiết lập tha-thu -> vẫn là ta mà

        //Một SV có GPA, kì này có điểm mới, Phải được cập nhật
        public void SetGpa(double gpa) =>    _gpa = gpa;
        
    }
}
        //Hắc não: Hàm Set() giống và khác Cái Phễu constructor như thế nào??
        //Giống: đều đổ info vào vùng ram, vùng new
        //khác: Phễu constructor mỗi lần gọi, là 1 lần xin ram cho object, tạo mới object, tạo mới tài khoản mạng xã hội
        //      Hàm SET() mỗi lần gọi, là đổ vào vùng ram cũ đã new trước đó, chỉnh sửa vùng ram đã có, không tạo mới vùng ram object.
        // thằng nào cũng được gọi nhiều lần
        //SET() mà gọi giống mình đi makeup, xăm, nhuộm tóc.

        //Hàm SET() là của từng object mỗi người có nhu cầu độ khác nhau -> khi gọi đi kèm biến object, an.SetGpa(),
        //        binh.Set(),....


//Coding convention- Quy tắc đặt tên trong C#
//I. Tên của Solution

//II. Tên của Project

//III. Tên của Namespace

//IV. Tên của Class, Interface, Delegates
//1. Tên class
//- Danh từ, chữ hoa từng đầu từ - Pascal Case Notation -> Bắt chước theo ngôn ngữ lập trình Pascal
//* Ví dụ: Student, Lecturer, Dog, Cat, File, Console, ArrayList...

//V. Tên biến (Biến cục bộ trong hàm, Biến ngoài hàm Fields)
//1. "Biến toàn cục" Field/ Attribute
//-Danh từ, cú pháp con Lạc Đà, camel Case Notation Chữ Hoa Từng Đầu từ, từ đầu tiên viết chữ thường, kèm _ đứng đầu
// * Ví dụ: _id, _name, _salary, _basicSalary

//2. PROPERTY (BIẾN LAI VỚI HÀM - LÀM GET SET THEO KIỂU MLEM)
//* PROPERTY LÀ KĨ THUẬT VIẾT HÀM GET SET GỌN GÀNG QUA STYLE XÀI BIẾN, TA ĐỘ THÊM 1 BIẾN VÀ NÓ BAO CÁI _FIELD QUA 2 HÀM GET SET XÀI TỰ NHIÊN QUA BIẾN LAI PROPERTY.
//TÊN "BIẾN LAI" PROPERTY PHẢI LÀ DANH TỪ, CHỮ HOA TỪNG ĐẦU TỪ(PASCAL CASE), KHÔNG CÓ ĐỘNG TỪ DO ĐỘNG TỪ GET SET BỊ CHE BÊN TRONG PROPERTY NÀY.
//CÓ NHIỀU KĨ THUẬT XÀI PROPERTY, TỪ V3 TRỞ ĐI 

//2. Ví dụ: Biến cục bộ - local variable - biến nằm trong hàm, hoặc tham số hàm Parameter.
//- Danh từ, cú pháp con lạc đà, từ đầu tiên chữn thường, cá từ còn lại chữ hoa từng đầu từ.
//* Ví dụ: salary, sum, count, yob, basicSalary

//VI. Tên hàm (Method)
//- Verb + Object, Cú pháp Pascal, Pascal Case Notation
// Chữ hoa từng đầu từ, Từ Đầu Tiên Là Động Từ.
//* Ví dụ: GetName(), Student(), ToString(), Main(), Convert(), SetName()
