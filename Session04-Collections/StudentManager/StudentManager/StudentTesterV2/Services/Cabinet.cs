using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: Trinh, Type: lần đầu teien trái thanh long 
                    // lần đầu tiên còn chưa beiét data type nào ta sẽ chơi với, data type cũng là tham số
    //value là tham số F(int x)
    //DATA type là tham số F(T X)
    //Xài sao
    //Cabinet<Student> tuSE;
    //Cabinet<Lecturer> tuGVSE = new Cabinet<Lecturer>();
    public class Cabinet<T>
    {
        private T[] _arr; //T có thể là Student, Lecturerl
        private int _count = 0;
        public Cabinet(int size ) 
        {
            _arr = new T[size];
        }

        public void Add(T item)
        {
            _arr[_count++] = item;
        }
    }
}
