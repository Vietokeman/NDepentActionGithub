using StudentTester.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class LecTurerCabinet
    {
        private Lecturer[] _arr;
        private int _count;
        public LecTurerCabinet(int size)
        {
            if (size < 1) size = 69;
            _arr = new Lecturer[size];
        }

        public void AddLecturer(Lecturer l)
        {
            //to do: check tran` mang!!
            _arr[_count++]= l;
        }
        public int? FindLecturerById(string id)
        {
            if (_count == 0) return null;
            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Id.ToLower() == id.ToLower())
                {
                    return i;
                }
            }
            return null;
        }
        public void PrintLecturerList()
        {
            Console.WriteLine($"There is/are {_count} lecturers in list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
