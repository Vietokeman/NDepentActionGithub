namespace NullableTester
{
    // TRONG KHUÔN VIÊN NAMESPACE CHỈ CHỨA CÁC CLASS VÀ NHỮNG THẰNG NGANG CƠ CLASS: INTERFACE, DELEGATES

    // CÓ THỂ KHAI BÁO CLASS GỘP CHUNG TRONG 1 TẬP TIN VẬT LÝ NHƯ BÀI NÀY HOẶC TÁCH RIÊNG MỖI CLASS 1 TẬP TIN .CS RIÊNG
    // NHƯNG CHUNG HAY RIÊNG THÌ ĐỀU PHẢI KHAI BÁO HỘ KHẨU - NHÀ/ CLASS Ở HỘ KHẨU - NAMESPACE NÀO!!!
    // NHA SĨ KHUYÊN DÙNG: TRỪ TÍNH HUỐNG ĐẶC BIỆT, THÌ NÊN TÁCH MỖI CLASS 1 TẬP TIN .CS CHO DỄ DÀNG QUẢN LÝ SOURCE CODE
    // VÀ KHAI BÁO CHÚNG CHUNG NAMESPACE
    // 1 PROJECT CPS THỂ NHIỀU NAMESPACE!!! dao, dto, controller.
    // Dao, DAO, DTO Dto

    public class Student
    {   //phá oop 1 chút, không dùng ENCAPSULATION
        // MẶC ÁO XUYÊN THẤU
        public string id;
        public string name;
        public int yob;
        public double gpa;
        public void FlexProfile()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("name: " + name);

            Console.WriteLine("yob: " + yob);

            Console.WriteLine("gpa: " + gpa);

        }
        //ko che giấu thông tin, public là ai cũng thấy ~ bài viết public, biography public
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //      biến object         object: vùng ram chứa infor của object
            //                            new: xin vùng ram bự ~ malloc():memory allocation

            s.id = "SE180672";
            s.name = " Nguyễn Việt đẹp trai";
            s.yob = 2004;
            s.gpa = 10.00;


            //s.FlexProfile();
            //s = null;// bien object = null co nghia la tra ve day ram, khong co code o do, cham 1 cai gi do, goi ham cua class se bi Null Reference Exception do day ram k co code de ma chay
            //Dung NULL de lam gi???
            //1. Huy vung object da new, do bien da tro vung khac, dieu dut day.
            //2. Dung de noi bien khong dang tro object nao.
            //2.1 Khi ban search 1 object trong LIST, tim 1 sv trong 500 ae.
            // tim khong thay thi tra ve null
            // s = null; return s;
            //s.FlexProfile();//exception
                            //dung toan tu is null, ==null, != null de check bien co dang khong tro vao ai hay khong
   
            if (s is null)
            {
                Console.WriteLine("No student is specified, Nothing to print");
            }
            else
            {
                s.FlexProfile();//no longer exception
                                //không che giấu thông tin, public thì ai cug thấy ~ bài viết public, biography public

                //Trong DB co khai niem NULL tren CELL( Hang cot giao nhau), cot diem PE, cot diem TE
                //Null mang y nghia rang cot/CELL do co value nhung chua biet chinh xac la value gi, tu tu se co, chac xac dinh roi se co
                //Co 1 cai gi do dien ta trang thai tam thoi bo trong, sau do dien vao sau
                // NULL la 1 trang thai, tinh trang cua Cot du lieu chua xac dinh duoc value.
                //Anh xa nguoc len CODE(CODE class STUDENT duoc MAP thanh 1 dong trong TABLE) lam sao de dien ta COT diem chua xac dinh trong lap trinh???
                //double pe = null; //bien primitive - gia tri don khong co khai niem null - gia tri phai la con so nao do!!! khong dien ta duoc trang thai em chua co gi, em chua xac dinh
                //JAVA: int -> Integer mang null okie(wrapper class)
                //      long Long, double Double, char Character

                //C#: dùng toán tử/keyword/kí hiệu ? đi kèm primitive/value-type giúp mở rộng primitive cho phép mang thếp giá trị null

                double? pe = null;// y chang double, chỉ thêm value null. Ta xài is null, == nul, != null như truyền thống để check điểm
                pe = 8.6;
                if(pe is null)
                    Console.WriteLine("Điểm chưa có em ơi, chờ đi...");
                else
                    Console.WriteLine("Điểm nè em: " + pe);
            }
            // hỏi chấm gắn với các data type primitive/ value-type giúp các biến của loại data type mới này được mang thêm giá trị NULL mang ý nghĩa biến chưa xác định chính xác value từ từ sẽ có
            //Ta có: int? long? float? double? char? bool?
            //Đám này được gọi là Nullable data type.
            //vậy em có thể mang giá trị null ngoài giá trị truyền thống.
            
            //Vậy Student? s;Lecture? l;Product? p;
            //    Student  s;Lecture  l;Product  p;
            //? không là vấn đề vì biến object sinh ra đã sẵn được mang null.
            //Đôi khi mình cần Student? vì IDE hay warning khi mình gán s = null;
            //Hàm search hay dùng null để nói rằng chưa biết không tìm thấy.
            //value = null để nói rằng thông tin của biến chưa xác định
        }
    }
}
