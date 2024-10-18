namespace PassByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            PowerByTwo(n);
            Console.WriteLine("In Main,after call method, n now is " + n);
        }
        // TRUYỀN THÁI Y STYLE THAM TRỊ, GIỐNG C, JAVA - pass by value
        // TA DÙNG TRONG TÌNH HUỐNG DATA TYPE LÀ KIỂU
        //PRIMITIVE (JAVA): int, long, float, double, chả, boolean
        //VALUE-TYPE (#): int, long, float, float, double, char, bool...
        //TRONG HÀM MÀ CÓ SỬA, BÊN NGOÀI VẪN GIỮ NGUYÊN
        //CHANGLENGE: VIẾT HÀM NHẬN VÔ 1 CON SỐ VÀ BÌNH PHƯƠNG NÓ LÊN.
        static void PowerByTwo(int n)
        {
            //nhận vào n và bình phương lên
            Console.WriteLine("in method, before changing, n is " + n);
            n = n * n; //Math.Pow(n, 2)
            Console.WriteLine("in method, after changing, n now is {0}",n);
        }
        static void PowerByTwoV2(in int n)
        {   
            // IN mang Ý nghĩa làm cho biến đầu vào trở thành READ ONLY, Cấm SỬA GIÁ TRỊ ĐẦU VÀO, CHỈ ĐƯỢC DÙNG

            //CHALENGE Ở NHÀ: Điều gì xảu ra nếu tham số đầu vào là 
            //(in Student x), bến đầu vào là object, thì in mang ý nghĩa read only như thế nào???
            //in cấm biến = 1 giá trị khác; = giá trị khác là thay đổi value
            // in cấm thay đồi value
           // n = n * n; 
            Console.WriteLine("in method, after changing, n now is {0}", n);
        }
    }
}
