using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student

    {
        private string _id;
        private string _name;

        private int _yob;

        private double _gpa;

        public Student(){}

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }


        //GET va SET
        // Id là 1 thứ lai giữa biến và hàm, bao get/set lại
        //nhưng xài get/set qua style gán giá trị cho biến
        //cw.(Id) ~~~ cw(getId()) return _id
        //.Id = "SE1", VALUE = SE1, _id = SE1
        // chơi biến nhưng là gọi hàm => tự nhiên trong viết
        // thay đổi giá trị biến là set, gọi tên biến là get
        //getName() setName() ko tự nhiên
        // Name = .. tự nhiên
        //PROPERTY OF A CLASS
        public string Id
        {
            get
            {
                return _id;//BACKING FIELD
            }
            set
            {
                _id = value;
            }
            //.Id sẽ là get value của Id
            //.Id = "SE123456:; -> set id
        }

        //GetNam SetName
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public override string? ToString() => $"{Id} {Name} {Yob} {Gpa}";
    }

}
// XÀI PROPERTY NGHĨA LÀ TA CHẾ RA 1 BIẾN - LAI VỚI HÀM, BAO BÊN TRONG 2 HÀM GET() SET() TRUYỀN THỐNG, 2 HÀM NÀY THAO TÁC TRÊN _FIELD ĐỂ LƯU TRỮ/ THAO TÁC CÁC ATTRIBUTE CỦA 1 OBJECT/CLASS
//_FIELD LÚC NÀY ĐƯỢC GỌI LÀ HẬU PHƯƠNG CỦA BIẾN LAI Id, Name, Yob, Gpa...
//ĐẰNG SAU THÀNH CÔNG CỦA NGƯỜI ĐÀN ÔNG LÀ...
//ĐẲNG SAU PROPERTY LÀ BIẾN _FIELD LO CHO VIỆC GET/SET
//                          _FIELD ĐƯỢC GỌI TÊN MỚI: BACKING FIELD
//                          _id, _name, _yob, _gpa: backing field