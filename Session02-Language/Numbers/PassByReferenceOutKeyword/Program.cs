namespace PassByReferenceOutKeyword
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //int x = 2204;
            //PlayWithOut(out x);
            //Console.WriteLine("x = "+ x);

            //int y;
            //PlayWithOut(out y);
            //Console.WriteLine("x = " + y);
            ////ChatGPT 
            //PlayWithOut(out int z);//inline style
            ////khai báo biến ngay trong lời gọi hàm out cho tiện
            //Console.WriteLine("z = " + z);




            int sumA = SumIntegerListV2(out int sumOdds, out int sumEvens);
            Console.WriteLine("Sum odd: " + sumOdds);
            Console.WriteLine("Sum even: " + sumEvens);
            Console.WriteLine("Sum : " + sumA);
        }
        // khi chơi với hàm out k cần gán giá trị cho biến đầu vào vì nó sẽ bị Hàm đè lên giá trị mới, do OUT hứa sẽ có giá trị trả về.
        // out ~~ return
        // Hàm có từ khóa out ở tham số sẽ biến hàm này thành hàm có return
        // em hứa sẽ có 1 giá trị của n được tạo ra ở trong hàm, em hứa sẽ return n
        // Trong hàm mà sửa, bên ngoài bị sửa theo



        // HÀM MÀ CÓ OUT, THÌ BIẾN TRONG HÀM CHÍNH LÀ CON TRỎ TRỎ ĐẾN BIẾN BÊN NGOÀI HÀM
        //KHI GỌI HÀM OUT, CHÍNH LÀ ĐƯA ĐỊA CHỈ BIẾN GỐC CHO HÀM OUT SỬA => PASS BY REFERENCE
        //HÀM OUT CHIẾU VÀO BIẾN NGOÀI, THAY ĐỔI BIẾN BÊN NGOÀI
        //TRONG HÀM MÀ SỬA, BÊN NGOÀI BỊ SỬA THEO

        //PASS BY REFERENCE XẢY RA VỚI:
        // - BIẾN OBJJECT, VÍ DỤ Student s; Lecture l; Dog chihuhu;
        //TRUYỀN THỐNG XƯA NAY

        //-BIẾN PRIMITIVE/ VALUE-TYPE: int long float double char bool/boolean ĐI KÈM TỪ KHÓA OUT, REF
        // KHI NÀO THÌ DÙNG OUT???
        //CHALLENGE: VIẾT HÀM TRẢ VỀ: TỔNG CỦA CÁC SỐ TỪ 1...10 (DỄ KIỂM TRA KẾT QUẢ)
        //                    TRẢ VỀ: TỔNG CÁC SỐ CHẴN, TỔNG CÁC SỐ LẺ, TRẢ VỀ CÓ BAO NHIÊU SỐ NGUYÊN TỐ...

        // CHỈ VIẾT 1 HÀM!!!
        static int SumIntegerListV2(out int sum0dds, out int sumEvens)
        {
            int sumA = 0;
            sum0dds = 0; //odd
            sumEvens = 0; //even
            for (int i = 1; i <= 10; i++)
            {
                sumA += i; //cứ gặp số là cộng
                if (i % 2 == 1)
                {
                    sum0dds += i;
                }
                else
                {
                    sumEvens += i;
                }
            }
            //sum0dds = sumO;
            //sumEvens = sumE;
            return sumA;
        }



        static int SumIntegerList(out int sum0dds, out int sumEvens)
        {
            int sumA = 0;
            int sumO = 0; //odd
            int sumE = 0; //even
            for (int i = 1; i <=10; i++)
            {
                sumA += i; //cứ gặp số là cộng
                if (i % 2 == 1)
                {
                    sumO += i;
                }
                else
                {
                    sumE += i;
                }
            }
            sum0dds = sumO;
            sumEvens = sumE;
            return sumA;
        }
        static void PlayWithOut(out int n)
        {
            n = 6789; // sbtc hỨa trả về qua ngả parameter
        }
    }
}
