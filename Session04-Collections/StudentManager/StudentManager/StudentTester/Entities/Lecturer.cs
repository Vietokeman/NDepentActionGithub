using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entities
{
    public class Lecturer
    {
        public string id { get; set; }
        public string name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString() => $"{id} {name} {Yob} {Salary}";
        
    }
}


//Ta lại cần 1 cái tủ đừng hồ sơ giảng viên
//nước sống không đụng nước giếng, mỗi class giải quyết câu chuyện riêng của nó solid - s : Single Responsibility
//Class lecturerCabinet xuất hiện, code y chang