using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentTester.Entities;

namespace StudentTester.Services
{
    public class LecturerCabinet
    {
        private Lecturer[] _arr;
        private int _count = 0;
        public LecturerCabinet(int size)
        {
            if (size <= 0) size = 69;
            _arr = new Lecturer[size];
        }

        public void AddLecturer(Lecturer lecturer) 
        {
            _arr[_count] = lecturer;
            _count++;
        }
        public int? SearchLecturerById(string id)
        {
            if (_count == 0) return null;

            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].id.ToLower() == id.ToLower()) return i;
            }
            return null;
        }
    }
}
