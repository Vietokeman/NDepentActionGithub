using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    public class Student
    {
            
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //kỹ thuật giấu backing field
        //runtime tự sinh ra backing field  tương ứng với mỗi property để dev đpữ ợảo gpx cpde mjoeeì, những đoạn code nhàm chán

        //đôi khi quên cú pháp auto thì làm sao
        //gõ prop tab tab
        public int MyProperty { get; set; }

    }
}


//khi nào xài kĩ thuật property: full property (backing field chủ đông) và auto-implemented property (giấu _backing field)
//thường ta hay xài với class với nó sẽ map với dât xuống table
//table là nơi set data và get data, xử lý để ở câu query, trong ram ở class khác)
//không ai cấm bạn xài property theo dậng full hoặc dạng auto ở các class khác bất kì