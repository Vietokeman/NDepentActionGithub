using StudentTester.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Services
{
    //T: TYPE ->Lan dau tien trai thanh long
    //          Lan dau tien ta con chua biet data type nao ta se choi voi, data type cung la tham so
    //value la tham so F(int x)
    //DATA TYPE LA` THAM SO F(T X)
    //xai sao:
    //Cabinet<Student> tuSe = new Cabinet<Student>();
    //Cabinet<Lecturer> tuGVSE = new()
    public class Cabinet<T> where T : class
    {
        private T[] _arr; //T co the la student, lecturer....
        private int _count;
        public Cabinet(int size)
        {
            if (size < 1) size = 69;
            _arr = new T[size];
        }
        public void Add(T item)
        {
            if (_count >= _arr.Length)
            {
                Console.WriteLine("Array is full.");
                return;
            }
            _arr[_count++] = item;
        }
        public void PrintList()
        {
            if (_count <= 0)
            {
                Console.WriteLine("The cabinet is empty. Nothing to print.");
            }
            else
            { 
                if (_count == _arr.Length)
                {
                    Console.WriteLine("The cabinet is full.");
                }
                Console.WriteLine($"There are {_count} item(s) in the cabinet:");
                for (int i = 0; i < _count; i++)
                    Console.WriteLine(_arr[i].ToString());
            }
            
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