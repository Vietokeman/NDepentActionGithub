using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //MỘT CLASS CÓ BAO NHIÊU CST: VÔ SỐ; BẠN MUỐN FILL DATA KIỂU NÀO: _id only; _id _name (*), ...
        //ĐIỀU GÌ XẢY RA NẾU KHÔNG TẠO CONSTRUCTOR => RUNTIME SẼ TẠO CHO BẠN 1 CONSTRUCTOR DEFAULT/ EMTY CONSTRUCTOR
        //KHI XÀI CST DEFAULT THÌ THÔNG TIN ĐƯỢC ĐỔ THẾ NÀO???
        //NGOÀI ĐỜI GIỐNG TÌNH HUỐNG: CÔ GIAO DỊCH VIÊN ĐƯA CHO MÌNH FORM TRẮNG (PHOTO TỪ FORM GỐC) MÌNH CHƯA FILL INFO NHƯNG NÓ LÀ PHIÊN BẢN CỦA MÌNH
        //TA VẪN NEW ĐƯỢC 1 OBJECT NHƯNG INFO BỎ TRỐNG, DEFAULT
        // STRING -> EMTY
        // SỐ -> 0


        //TUY NHIÊN TA CÓ THỂ CHỦ ĐỘNG TẠO SẴN  1 CST DEFAULT(EXPLICIT EMTY CONSTRUCTOR - TƯỜNG MINH RÕ RÀNG)
        // NGẦM TẠO GIÚP MÌNH GỌI LÀ IMPLICIT EMPTY CONSTRUCTOR
        //                              KHÔNG TƯỜNG MINH
        public Student() { }// explicit empty constructor

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        //tạo cst empty và các cst khác:
        // Ctrl .
        //có bn cst, có bấy nhiêu các new object
        // nếu class đã có sẵn 1 cst nào đó, thì runtime k tạo giúp empty cst nữa, trừ khi bạn chủ động tạo explicit nó
        // mục tiêu cuối: class cần có ít nhất 1 cst để đúc object

        //đúc xong thì có objject, ta sẽ xem get() sửa set() xem tất cả flexProfile().

        public void FlexProfile() => Console.WriteLine($"{_id} {_name} {_yob} {_gpa}");

        public override string? ToString() => $"{_id} {_name} {_yob} {_gpa}";

        //GET và SET: thay đổi info của object, lấy từng miếng info của object
        //ToString() Flex() là lấy hết
        //Lý thuyết: có N fields thì có N x 2 Hàm GET() SET()
        //4 fields = 8 hàm

        public string GetId() => _id;
        public string GetName => _name;
        public int GetYob() => _yob;
        public double GetGgpa() => _gpa;    

        //SET luôn cần 1 value đưa vào dưới hàm đưa id

        public void SetId(string id) {  _id = id; }
        public void SetName(string name) { _name = name; }
        public void SetYob(int yob) { _yob = yob; }
        public void SetGpa(double gpa) { _gpa = gpa; }


        //Đoạn code get/set viết theo style này rất nhàm chán, quen thuộc, nhưng vẫn phải làm, vì nó giúp object có tương tác: cung cấp info, tiếp nhận info
        //bắt buộc phải làm, lặp đi lặp lại và nhàm chán
        //người ta gọi là boiler plate


        //C# sẽ giúp bạn 1 style mới (java chưa có) tránh code boiler plate


    }
}
