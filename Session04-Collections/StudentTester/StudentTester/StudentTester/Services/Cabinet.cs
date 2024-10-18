using StudentTester.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    //1 cai tu thi chua nhieu ho so
    //co the bo sung them, bot di, sap xep ... -> CRUD METHOD
    //MUON CHUA NHIEU HO SO, TA CAN 1 MANG ....
    //MANG DI KEM BIEN COUNT DE BIET TU DAY CHUA
    //GIONG NHU ANH CHANG O QUAY DICH VU GIU GIO, NHIN SO CHIA KHOA CAM TREN CAI CUA, BIET TU FULL CHUA
    public class Cabinet
    {

        private Student[] _arr;
        private int _count = 0;

        //public Cabinet(int size)
        //{
        //    if(size<0) throw new ArgumentOutOfRangeException("Invalid size! Size must be >= 1");
        //    _arr = new Student[size];
        //} 

        //mở rộng có constructor là new vô tận số objecct
        //           Constructor ném ra ngoại lệ thì tính huống đó ko new đc object, ko tạo đc object
        //           Nếu muốn trong ram chỉ có duy nhất 1 object được tạo ra, ko nhiều hơn 1 vùng new => SINGLETON!!! (phải hiểu static)
        //DESIGN PATTERNS - CÁC MẪU THIẾT KẾ CLASS - SÁCH CỦA GOF - GANG OF FOUR
        //BÀ CON VỚI SOLID
        //No la kien thuc nen cua nghe, vi tri tuyen dung: SA - Solution Architect - Code ra dan khung cua app, chi de xuat danh sach cac class/interface de giup ap de dang tich hop va mo rong phat trien.
        //mức lương 5000$/ month.
        //search website: của edward thiên hoàng
        public Cabinet(int size)
        {
            if (size < 1) size = 69;
            _arr = new Student[size];
        }
        //_count tang dan ++ khi them tung ho so vao vi tri thu count cua mang, ban dau la` 0,1,2,...
        //den khi mang full
        //ham` crud!!! ho so sinh vien
        //coi như cái tủ đã đóng xong qua việc new cabinet(500)
        //ta đang có mảng 500/hoặc size phần tử
        //Student[] _arr = new Student[500/size];

        //giờ là lúc _arr[i] = new Student(){...}
        //hàm add student, cái tủ mở cánh của ra nhận hồ sơ sinh viên 
        //UI CONSOLE, WEB, FORM/WINDOW CO' MAY O NHAP ID, NAME, YOB, GPA, CO NUT NHAN NEW STUDENT(){} DAY XUONG HAM`
        public void AddStudent(Student s)
        {
            _arr[_count] = s;//phan tu thu [i] la 1 bien con tro tro vung new Student(){..}
            _count++;
        }
        //overload
        public void AddStudent(string id, string name, int yob, double gpa)
        {
            //to do:check mang co full hem????
            _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
        }
        //public void AddStudent(string id, string name, int yob, double gpa) => _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa }; dung expression boby

        //da co danh sach student, co the chua full, in danh sach
        public void PrintStudentList()
        {
            Console.WriteLine($"There is/are {_count} student(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);//goi tham ten em
            }
        }

        public void DeleteStudent(string id)
        {
            //co id thi tim ra vi tri
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _arr[j] = _arr[j + 1];
                    }
                    _arr[_count - 1] = null;
                    _count--;
                    return;
                }
            }
        }
        public void UpdateStudent(string id, string? newName, int? newYob, double? newGpa)
        {
            int? pos = FindStudentById(id);
            if (pos.HasValue) //<=> if(pos != null
            {
                if (newName != null)
                {
                    _arr[(int)pos].Name = newName; //set name moi cua chau thu i
                }
                if(newYob != null)
                {
                    _arr[(int)pos].Yob = (int)newYob;
                }
                if(newGpa != null)
                {
                    _arr[(int)pos].Gpa = (double)newGpa;
                }
                //TODO at home: them cau if de check neu ta dua vao null cua gpa, cua yob, cua name , giu nhu cu ko doi [pos], con khac null thi moi doi
            }
        }
        //phat sinh ha`m tim mot vi tri theo ID
        //chuoi string/String trong JAVA va c# deu la bien object
        //bien chuoi tro vung new String s1 = "HELLO"; s2 = "hello";
        //thi s1 chac chan khac s2 do 2 con tro tro vao 2 vung new khac nhau
        //ko bao gio kieu s1==s2 hay k do dang so sanh 2 dia chi, 2 con tro
        //JAVA: s1.equalIgnoreCase(s2) goi ha`m de vao vung ram lay chuoi ra ma` so
        //c#: c# cho phepp dung == de so sanh 2 chuoi do no da overriee lai toan tu == cua so cho bien object
        //tuy nhien java, c#, c deu phan biet hoa thuong!! CHU HOA KHAC T thuong do ma ASCII khac nhau!!!
        //KHI SO SANH TA HAY DOI VE CUNG HOA, CUNG THUONG DE SO
        public int? FindStudentById(string id)
        {
            //quet mang tu dau den count coi moi dua [I].ID co bang ID dang tim hem> neu co tra ve vi tri, neu k thay thi tra ve null (pro hon tra ve -1)
            if (_count == 0) return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    return i;
                }
            }
            return null;
        }
    }
}

//tai sao tui ko lam property ma lai dung _backing field
//mang nay fix 365, o ngoai doi dong tu da dang kich thuoc, co the kich thuoc theo yeu cau, vay nguoi nong dan phai lam` sao de tu dong theo yeu cau
//BAI TAP VE NHA 
//1.Hoan tat not ham xoa 1 phan tu cua mang(doi cho tro [I] [J])
//2. Hoan tat not ha`m update 1 phan tu cua mang (viet them if)
//3.