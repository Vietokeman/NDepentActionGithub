namespace PassByReferenceRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 19;
            PlayWithOut(out x);
            Console.WriteLine("x "+ x);

            PlayWithOut(out int y);
            Console.WriteLine("y " + y);

            //REF
            int z = 6969;
            PlayWithRef(ref z);// vì hàm không hứa nên z phải có giá trị sẵn để đảm bảo tính logic: gọi hàm xong thì phải có value - hàm để xử lí info
            Console.WriteLine("Z " + z);


            //PlayWithRef(ref int zzz ); không hỗ trợ inline ới ref
            // do inline chỉ mang ý nghĩa kahi báo biến, không gán value

        }
        //OUT, REF LA 2 KEYWORD SẼ BEIÉN THAM SỐ ĐẦU VÀO TRỞ THÀNH CON TRỎ, POINTER, REFERENCE, THAM CHIẾU BẤT CHẤP BIẾN NÀY LÀ PRIMITIVE HAY LÀ BIẾN OBJECT
        //BIẾN OBJECT Students s, bản chất đã là reference rồi!!!
        static void PlayWithRef(ref int n)
        {
            //trong hàm thay đổi bên ngoài đổi theo
            //REF: không hứa sẽ có value
        }
        static void PlayWithOut(out int n)
        {
            n = 3979; //49 53
            //out: hàm hứa chắc kèo sẽ có 1 N được tạo ra, được gán giá trị
            //trong hàm thay đổi, bên ngoài đổi theo
        }
    }
}
