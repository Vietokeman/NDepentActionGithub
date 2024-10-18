using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    //1 cái tủ thì chứa nhiều hồ sơ, có thể bổ sung thêm, bớt đi, sắp xếp -> crud method
    //Muốn chứa nhiều hồ sơ, ta cần 1 mảng....
    //Mảng đi kèm biến count để biết tủ đầy chưa
    //Giống như anh chàng ở quầy dịch vụ giữ giỏ, nhìn số chìa khóa cắm trên tủ, biết tủ full chưa
    public class Cabinet
    {
        private Student[] _arr;
        private int _count = 0;


        //public Cabinet(int size)
        //{
        //    if (size < 0) throw new ArgumentOutOfRangeException("Invalid size! Size must be >= 1");
        //    _arr = new Student[size];

        //}
        //Mo rong: co constructor la new vo tan so object
        //         constructor nem ra ngoai le thi tinh uong do khong new duoc object, khong tao duoc object
        //         Neu muon trong ram chi co duy nhat 1 object duoc tao ra,
        //         Khong nhieu hon 1 vung new => SINGLETON!!! ( phai hiểu static)
        //Design patterns - các mẫu, kĩ thuật thiết kế CLASS - Sách của GoF - GANG OF FOUR
        //Bà con với SOLID
        public Cabinet(int size)
        {
            if (size < 1)
                size = 69;
            _arr = new Student[size];
        }
        //_count tăng dần ++ khi thêm từng hồ sơ vào vị trí thứ count của mảng, ban đầu là 0, 1, 2,... đến khi mảng full
        //Tại sao k làm property ma lai dung _field
        //Mảng này fix 365, ở ngoài đời đóng tủ đa dạng kích thước, có thể theo yêu cầu, vậy tui phải làm sao để tủ đóng theo yêu cầu

        // coi như cái tủ đã đóng xong việc New Cabinet(500)
        // Ta đang có amngr 500/ hoặc size phần tử
        //Student[] _arr = new Student[500/size]

        //giờ là lúc _arr[i] = new Student(){...};
        //Hàm ADD Student, cái tủ mở cánh cửa ra nhận hồ sơ sv
        //UI CONSOLE, WEB, FORM/WINDOW Có MẤY Ô NHẬP ID, NAME, YOB, GPA, CÓ NÚT NHẤN, NEW STUDENT() {} ĐẨY XUỐNG HÀM
        public void AddStudent(Student s)
        {
            _arr[_count] = s;// phần tử [i] là 1 biến con trỏ trỏ vùng new Student(){...}

            _count++;

        }

        //Hàm overload
        public void AddStudent(string id, string name, int yob, double gpa)
        //todo: check mảng có full hem?
        { 
            _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
            //có thể viết thành Expression Bodđie/Body
        }

        //đã có danh sách student, co thể chưa full, in danh sách

        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");

            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]); // goi ten em trong dem
            }
        }

        //Hàm xóa và sửa 
        //Xóa Tại vị trí thứ I, xóa theo ID là 1 cách khác
        //Mảng có nhược điểm: fix kích thoức khi đã new
        //Nghĩa là mảng 500 sẽ là 500, xóa không được
        //vậy xóa làm sao, xóa là lừa đảo, xóa là dồn chỗ lên thôi
        //Giảm count-- nhưng kích thước mảng vẫn như cũ
        //vị trí    [0]   [1]   [2]   [3]   [4]
        //          5     10    15    20    35
        // tui mún xóa số 15
        //                  dồn 20 lên 15, dồn 25 lên chỗ 20 cũ.
        //                  [2]     = [3]
        //                            [3]   =     [4]   
        //                  [i] = [i+1]

        public void DeleteStudent(string id) 
        {
            //Có id tìm ra vị trị
           
                int? pos = SearchStudentById(id);

                if (pos.HasValue)
                {
                    for (int i = (int)pos; i < _count - 1; i++)
                    {
                        _arr[i] = _arr[i + 1]; 
                    }

                    _arr[_count - 1] = null; 
                    _count--; 
                    Console.WriteLine($"Student MSSV{id} has been deleted.");
                }
                else
                {
                    Console.WriteLine($"Student MSSV{id} not found.");
                }
            
        }
            public void UpdateStudent(string id, string? newName, int? newYob, double? newGpa)
            {
                // Tìm vị trí của sinh viên theo id
                int? pos = SearchStudentById(id);

                if (pos.HasValue)
                {
                    if (!string.IsNullOrEmpty(newName))
                    {
                        _arr[(int)pos].Name = newName;
                    }

                    if (newYob.HasValue)
                    {
                        _arr[(int)pos].Yob = newYob.Value;
                    }

                    if (newGpa.HasValue)
                    {
                        _arr[(int)pos].Gpa = newGpa.Value;
                    }

                    Console.WriteLine($"Student MSSV{id} has been updated.");
                }
                else
                {
                    Console.WriteLine($"Student MSSV{id} not found.");
                }
            
        }

        //Phát sinh hàm tìm một vị trí theo ID
        //Chuỗi String/string trong JAVA và C# đều là biến object
        //biến chuỗi trỏ vùng new String s1 = "HELLO"; s2 = "hello"
        // thì s1 chắc chắn khác s2 do 2 con trỏ trỏ vào 2 vùng new khác nhau
        //không bao giờ kiểu s1 == s2 hay không, do đang so sánh 2 địa chỉ, 2 con trỏ
        //JAVA: s1.equalIgnoreCase(s2) gọi hàm để vào vùng ram lấy chuỗi ra mà so
        //C#: cho phép được dùng == để so sánh 2 chuỗi do nó đã overide lại toán tử == của số cho biến object
        //tuy nhiên java, C#, C đều phân biệt hoa thường do mã ASCII khác nhau!!!
        // cho nên khi so sánh ta hay đổi về cùng hoa, cùng thường để so

        public int? SearchStudentById(string id)
        {
            //Quét mảng từ đầu đến cout coi mỗi đứa [I]. ID có bằng ID dang tìm hem? Nếu có trả về vị trí, nếu không thấy thì trả về(PRO hơn trả về -1)
            if (_count == 0)
                return null;


            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                    return i;
            }
            //hết for mà không bằng là không thấy
            return null;
        }
    }
}


//Bài tập về nhà: Viết ra giấy
//1. Hoàn tất nốt hàm xóa 1 phần tử của mảng (dời chỗ trỏ [i] [j])


//2. Hoàn tất nốt hàm update 1 phần tử của mảng( if nốt thui)
