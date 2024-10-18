using Bmi;
// import bmi; báo cho hàng xóm mình cần hắn giúp
namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)//svm tab ~ psvm bên java

        {
            //BmiCalculator.GetBmi(70, 1.7);
            Console.WriteLine("BMI: " + BmiCalculator.GetBmi(80, 1.7));

        }
        //trong class chứa: fields/ attributes và methods => gọi chung là: members of a class.
        // fields/ attribute: có 2 dạng, method cũng vậy
        // static                   non-static
        // class-level variable     instance variable


        //kĩ thuật cái dây nịt
        //              GetBmi: tên hàm - SIGNATURE OF A METHOD.
        //              {.... CODE CỦA HÀM - BODY OF A METHOD;}
        //              { THÂN HÀM, IMPLEMENTATION OF METHOD}
        // NẾU HẦM CHỈ CÓ DUY NHẤT 1 LỆNH, THÌ TA CÓ THỂ ÁP DỤNG QUY TẮC RÚT GỌN ĐỂ HÀM CHỈ CÒN CÁI DÂY NỊT MỨC TỐI THIÊU
        // TA DẸP BỎ{ ,RETURN, } CHỈ CÒN LẠI TÊN HÀM NỐI VỚI CODE THÂN HÀM TẠO QUA KÍ TỰ
        // TÊN HÀM => THÂN HÀM
        // KĨ THUẬT RÚT GỌN HÀM MÀ CHỈ CÓ 1 LỆNH ĐC GỌI LÀ EXPRESSION BODIED, EXPRESSION BODY
        // THÂN HÀM VIẾT GIỐNG NHƯ BIỂU THỨC!!!
        // CẤM TUYỆT ĐỐI K ĐƯỢC NHẦM LẪN => VỚI 1 KHÁI NIỆM KHÁC - BIỂU THỨC LAMBDA - LAMBDA EXPRESSION
        // CŨNG XÀI CHUNG KÍ HIỆU => HỌC SAU !!!
        //static void Main(string[] args)
        //{
        //    //PrintBmi(85, 1.70);
        //    double bmi = GetBmi(85, 1.7);
        //    Console.WriteLine("BMI: "+ GetBmi(85, 1.7));
        //    Console.WriteLine($"BMI: {GetBmi(85, 1.7)}" );
        //    Console.WriteLine("BMI: {0}", bmi);
        //    Console.WriteLine("BMI: " + bmi);
        //    Console.WriteLine($"BMI: {bmi}");

        //}

        //CHALLENG #1: VIẾT HÀM TÍNH VÀ IN RA CHỈ SỐ BMI- BODY MASS INDEX - CHỈ SỐ KHỐI CỦA CƠ THỂ - ĐO TÌNH TRẠNG MẬP ỐM CỦA AI ĐÓ THEO CÂN NẶNG VÀ CHIỀU CAO.
        //BMT = WEIGHT kg/ (HIGH m)^2
        // bmi [18.5 .... 24.9] => ỔN


        //TRIẾT LÍ THIẾT KẾ HÀM: 1 HÀM ĐƯUỌC THIẾT KẾ TỐT THÌ HÀM ĐÓ NÊN THUỘC STYLE.
        //HÀM NHẬN ĐẦU VÀO VÀ TRẢ RA KẾT QUẢ. HÀM KO NÊN CÓ LỆNH NHẬP VÀ IN TRONG CODE HÀM.
        // LÝ DO THIẾT KẾ HÀM STYLE NHẬN VÀO TRẢ RA SẼ GIÚP HÀM LINH HOẠT HƠN TRONG CÁCH NÓ ĐƯỢC SỬ DỤNG, HÀM SẼ ĐƯỢC DÙNG TRONG CÁC BIỂU THỨC KHÁC.
        // TĂNG TÍNH SỬ DỤNG LẠI - REUSE MỨC CAO.

        // VÍ DỤ LÚC TA VIẾT HÀM KIỂM TRA N CÓ PHẢI LÀ SỐ NGUYÊN TỐ KHÔNG.
        // for(int i = 2; i< n; i++)
        // giang hồ chứng minh chỉ cần for đến căn bậc 2.
        // for( int i = 2; i <= Math.Sqrt(n);i ++}
        static double GetBmi2(double weight, double height) => weight / Math.Pow(height, 2);
        
        static double GetBmi(double weight, double height)
        {
            //double bmi = weight / Math.Pow(height, 2);
            //return bmi;
            return weight / Math.Pow(height, 2);
        }
        static void PrintBmi(double weight, double height)
        {
            //double bmi = weight / (height  * height);
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine("BMI (w: {0}; h: {1} ) = {2}",weight,height,bmi);
            Console.WriteLine($"BMI (w: {weight}; h: {height} ) = {bmi}");

        }
    }
}
