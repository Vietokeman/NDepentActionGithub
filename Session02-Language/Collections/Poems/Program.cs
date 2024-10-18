namespace Poems
{
    //MỖI TẬP TIN SOURCE CODE SẼ PHẢI THUỘC VỀ 1 THƯ MỤC NÀO ĐÓ - GỌI LÀ XUẤT THÂN TỪ ĐÂU, LÀ LÀ ĐANG Ở CĂN PHÒNG NÀO. CĂN PHÒNG NÀY, THƯ MỤC ĐANG Ở ĐƯỢC GỌI LÀ PACKAGE(JAVA), CÒN C# GỌI LÀ NAMESPACE - KKO GIAN  ĐẶT TÊN, NƠI CHỨA CÁC CLAS/ TẬP TIN SOURCE CODE
    // ~ PACKAGE JAVA.ULTIL;
    // ~ PACKAGE POEMS;

    //TẠI SAO CẦN CÓ PACKAGE, NAMESPACE: GIÚP CHO VIỆC QUẢN LÍ NHIỀU TẬPP TIN SOURCE CODE TỐT HƠN. CHIA SOURCE CODE CÁC THƯ MỤC THEO NHÓM CHỨC NĂNG

    // GIÚP TRONG 1 PROJECT CÓ NHIỀU SOURCE CODE, NHIỀU CLASS, CÓ QUYỀN TRÙNG TÊN NHAU MIỄN LÀ KHÁC THƯ MỤC, KHÁC NAMESPACE.
    internal class Program
    {
        //field / attribute / property và method
        // static and non-static
        //íntance variable & class variable & method
        static void Main(string[] args)
        {
            PrintSongXuanQuynhV6();
            //PrintPath();
            //Console.ReadLine();
        }
        // Challenge #2: IN RA ĐƯỜNG DẪN TẬP TIN SAU
        // C:\Program Files\dotnet
        // C:\news\showbiz
        static void PrintSongXuanQuynhV6()
        {
            int year = 1967;
            Console.WriteLine("So'ng " + year);
            Console.WriteLine("So'ng " + year + "  " +(2024 - year) +" na(m");
            // ghép chuỗi dùng +

            Console.WriteLine("SO'NG {0} {1} nam", year, (2024 - year));
            // place holder, kĩ thuật điền vào chỗ trống trong chuỗi
            // {0}, {1} ... các biến bắt đầu đếm từ 0
            // 

            Console.WriteLine(@$"SO'NG {year} {2024-year} nam");
            //INTERPOLATION: PHÉP NỘI SUY, NHÌN SÂU VÀO CHUỖI
            // COI CÓ CHỖ NÀO LÀ BIẾN HEM? CÓ THÌ THAY THẾ VÀ ĐIỀN VÀO


            Console.WriteLine(@"
Dữ dội và dịu êm
Ồn ào và lặng lẽ
Sông không hiểu nổi mình
Sóng tìm ra tận bể");
            
        }
        static void PrintPath()
        {
            Console.WriteLine("C:\\Program Files\\dotnet");
            Console.WriteLine(@"C:\Program Files\dotnet");
            Console.WriteLine(@"C:\news\showbiz");
        }
        // có câu: static chơi với static
        //CHALLENGE #1: IN RA BÀI THƠ SÓNG CỦA XQ

        // @ đứng trước 1 cái chuỗi sẽ phế võ công TẤT CẢ CÁC KÍ TỰ ĐẶC BIỆT TRONG CHUOÕI TRỞ LẠI KÍ TỰ BÌNH THƯỜNG 
        // \n sẽ in ra \n thay vì xuống hàng
        //@ BIẾN CHUỖI THÀNH : CÓ SAO IN VẬY, WYSIWYG: what you see is what you get?
        //@ GỌI LÀ KĨ THUẬT CHUỖI NGUYÊN BẢN - RAW STRING
        //@ GỌI LÀ VERBATIM STRING
        // CÓ BÊN JAVA LUÔN

        // KHI NÀO DÙNG VERBATIM
        //1. PHẾ VÕ CÔNG KÍ TỰ ĐẶC BIỆT TRONG CHUỖI
        //2. DÙNG ĐỂ LƯU TRÊN CỦA CÁC DƯỜNG DẪN TẬP TIN, THƯ MỤC, CHUỖI KẾT NỐI CSDL DO TÊN SEVER HAY KÈM THEO KÍ TỰ ĐẶC BIỆT -> TA TRẢ CHUỖI VỀ NGUYÊN BẢN THÌ CHUỖI KHÔNG BỊ HIỂU SAI Ý NGHĨA
        static void PrintSongXuanQuynh()
        {
            Console.WriteLine("So'ng ba('t -da^u` tu+` gio'");// cw tab ~ sout trong jv
            Console.WriteLine("Gió bắt đầu từ đâu?");
            Console.WriteLine("Em cũng không biết nữa");
            Console.WriteLine("Khi nào ta yêu nhau");
        }
        static void PrintSongXuanQuynhV2()
        {
            Console.WriteLine("So'ng ba('t -da^u` tu+` gio'\nGió bắt đầu từ đâu?\nEm cũng không biết nữa\nKhi nào ta yêu nhau");
// \n mỗi khi xh trong chuỗi " thì được hiểu theo nghĩa không phải là in \n mà là in xuống hàng - kí tự đặc biệt
// kí tự \ đi kèm với \n \r \t \a mang 1 ý nghĩa nào đó ..., bị biến dạng không còn là in \ nữa
        }
        static void PrintSongXuanQuynhV3()
        {
            Console.WriteLine("So'ng ba('t -da^u` tu+` gio'\n" +
                "Gió bắt đầu từ đâu?\n" +
                "Em cũng không biết nữa\n" +
                "Khi nào ta yêu nhau");
    // + được gọi là toán tử -- operator để nối các chuỗi - string concatenation 
        }
        static void PrintSongXuanQuynhV4()
        {
            Console.WriteLine("Dữ dội và dịu êm\r\nỒn ào và lặng lẽ\r\nSông không hiểu nổi mình\r\nSóng tìm ra tận bể\r\n\r\nÔi con sóng ngày xưa\r\nVà ngày sau vẫn thế\r\nNỗi khát vọng tình yêu\r\nBồi hồi trong ngực trẻ\r\n\r\nTrước muôn trùng sóng bể\r\nEm nghĩ về anh, em\r\nEm nghĩ về biển lớn\r\nTừ nơi nào sóng lên?");
        }
        static void PrintSongXuanQuynhV5()
        {
            Console.WriteLine(@"Dữ dội và dịu êm

<html>
    <head>
        <title> Xin chào </title>
    </head>
    <body>
    </body>
</html>


                Ồn ào và lặng lẽ
                Sông không hiểu nổi mình
                Sóng tìm ra tận bể

                Ôi con sóng ngày xưa
                Và ngày sau vẫn thế
                Nỗi khát vọng tình yêu
                Bồi hồi trong ngực trẻ

                Trước muôn trùng sóng bể
                Em nghĩ về anh, em
                Em nghĩ về biển lớn
                Từ nơi nào sóng lên?");
        }


    }
}
