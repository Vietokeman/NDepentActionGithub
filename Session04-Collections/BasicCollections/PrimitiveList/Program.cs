using PrimitiveList.Entities;
using System.Collections;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentList();
            //PlayWithPrimitiveList();
        }

        static void PlayWithStudentList()
        {
            List<Student> tuSe = new List<Student>();
            tuSe.Add(new Student() { Id = "Toi la teo"});
            tuSe.Add(new Student() { Id = "Toi la ti" });



            Console.WriteLine("The list of Students");
            foreach (Student student in tuSe)
            {
                Console.WriteLine(student); // goi tham ten em
            }
        }

        static void PlayWithPrimitiveList()
        {
            List<int> arr = new List<int>();
            //tui hop chi chua duoc int, cam dua lonxon, chui lien
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);     
            arr.Add(10);    
            arr.Add(11);    
            arr.Add(12);

            //in list 
            Console.WriteLine("the size: " + arr.Count);//12 bien nhung con mo rong hon
            Console.WriteLine($"There is/are {arr.Count} item(s)");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            //Cabinet arr = new Cabinet();
            //arr.AddStudent(...); arr.AddLectuter()
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(20);
            array.Add("Hello");
            array.Add(3.14);
            array.Add(true);
            array.Add(new Student() { });

            //Console.WriteLine($"There is/are {array.Count} item(s)");



            foreach (var item in array)
            {
                //Console.WriteLine(item);
            }




            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr.ElementAt(i));
                //Console.WriteLine(array[i]);
            }
        }
    }
}

//để lưu nhiều dữ liệu (primitive, object) trong ram, ta dùng nhóm class thay cho mảng để fix cho những hạn chế của mảng
//những class này khi nó được new thì bên trong vùng new neà sẽ dự định chứa nhiều biến khác -
// y chang vùng new mảng sẽ chứa nhiều biến bên trong
//khác mảng: vùng nhớ này co giãn chứa nhiều thì nở ra, chứa ít thì hẹp lại, xóa thì mất luôn cái xóa... co giãn linh hoạt
//nồi cơm thạch sanh, túi anh em cây khế
//toàn bộ các nhóm class này gọi là collections
//chúng sẽ gồm nhiều interface, nhiều abstract class      nhiều class cụ thể
//
//                  không new được, vì chứa hàm k code    new được, concrete class

//java:
//abstract class, interface: list           Set                      Map(ko new)
//concrete class, new được : arrayList    HashSet,   TreeSet        HashMap, TreeMap
//                        vào thứ tự        ngẫu nhiên| sắp xếp 
//                        ra thứ tự mấy

//khai báo: list<Student> arr = new List<Student>(); //vỡ mặt, vì sẽ sinh ra cỡ 20 hàm không code, yêu cầu code tiếp/implement -> annonynmous class 1 câu chuyện khác -> cấm nhen!!!


//khai cha new con okie
//List<Student> arr = new ArrayList<>();
//Khai con new con, chuyện quá quen
//ArrayList<Student> arr = new ArrayList<>();



//C#???
//ArrayList không bà con gì với List'
//ArrayList chứa cái gì bên trong cũng được không generic, và new được


//Líst Concrete class luon, tuc la new duoc ngay va luon, va xai generic
//tuc la chi add 1 loai data type ~ y chang Cabinet<> nha minh
//List<Student> List<Lecturer> okie

//Nha sĩ khuyên dùng: Dùng list, không dùng arraylist, thằng arrlist không ép được data type đưa vào cùng 1 sytle



