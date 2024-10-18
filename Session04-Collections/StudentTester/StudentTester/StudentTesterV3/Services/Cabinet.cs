using StudentTester.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //class cabinet nếu design chỉ chơi Student hoặc Lecturer hoặc Pet... -> gọi là Tight coupling
    //Tuy nhiên code của chúng tương đồng nhau, vậy tại sao lại phải làm nhiều class mà code tương đồng nhau, hãy để class cabinet ko chơi với 1 clâss cụ thể nào, hãy buông các class cụ thể ra, mà nên hứa hẹn là: tui cabinet sẽ chơi được với nhiều class khác nhau -> ko gắn kết chặt chẽ thì gọi là loose coupling -> giúp cho class hoạt động linh hoạt, dễ dàng mở rongọ, dễ dàng thích ứng với nhiều tình huống
    //RED LABLE, BLUE LABEL, CHIVAS, HENNESSY XÚC MIỆNG VÌ HIỂU SOLUTION ARCHITECT, THIẾT KẾ KIẾN TRÚC APP

    //CLASS CABINET CÓ THỂ LÀM VIỆC VỚI ĐỦ DẠNG CLASS KHÁC NHAU, NẾU TA CHỈ CẦN CRUD TRÊN CÁC OBJECT CỦA CÁC CLASS NÀY
    public class Cabinet<T> where T : class
    {
        private T[] _arr; //T co the la student, lecturer....
        private int _count;
        public Cabinet(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("out of size");
            _arr = new T[size];
        }
        public void Add(T item)
        {
            if (_count == _arr.Length)
            {
                Console.WriteLine("Array is full.");
                return;
            }
            _arr[_count++] = item;
        }
        public void PrintList()
        {
            if (_count == 0)
            {
                Console.WriteLine("The cabinet is empty. Nothing to print.");
            }
            else
            { 
                if (_count == _arr.Length)
                {
                    Console.WriteLine("The cabinet is full.");
                }
                Console.WriteLine($"There is/are {_count} item(s) in the cabinet:");
                for (int i = 0; i < _count; i++)
                    Console.WriteLine(_arr[i].ToString());
            }//cấm tuyệt đối for tới length, vì phần còn lại mảng là null
            
        }
        public void Delete(Func<T, bool> check)
        {
            for (int i = 0; i < _count; i++)
            {
                if (check(_arr[i]))
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _arr[j] = _arr[j + 1];
                    }
                    _arr[_count - 1] = null;
                    _count--;
                    return;
                }
            }
        }
        public void Update(Func<T, bool> check, T? updatedItem)
        {
            for (int i = 0; i < _count; i++)
            {
                if (check(_arr[i]))
                {
                    if(updatedItem != null)
                    {
                        _arr[i] = updatedItem;
                    }
                    return;
                }
            }
        }
    }
}
//hoan tat not class nay` va` code main thu nghiem