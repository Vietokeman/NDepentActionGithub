using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private double _gpa;

        private int _yob;

        public string Id
        {
            get { return _id; }
            set { _id = value; }


        }
        //lỡ quên cách viết, mà chưa gợi ý
        //propfull tab tab

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public string Name
        {
            get => _name; set => _name = value; 
        }

        //sau khi có prop, thì ta làm tiếp ToString() và các hàm còn lại
        //New qua cách thức:
        // truyền thống đủ 2 vế, ăn bớt trái - var. ăn bớt phải bỏ data type còn new(), named-argument, object initialization

        //get/set kiểu mới dù dễ thương, dùng tự nhiên
        //theo stype biến = (set) biến (get), những vẫn là boiler plate do gặp lại thứ đã quen!!!
        // tuyệt chiêu cuối rút gọn tiếp GET() SET()

    }
}