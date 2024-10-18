using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entites
{
    public class Lecturer
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString()=> $"{Id} | {Name} | {Yob} | {Salary}";
    }
}

//ta lai can 1 cai tu dung ho so giang vien 
//nuoc song k dung nuoc gieng, moi class giai quyet cau  chuyen cua rieng no - solid - s: single responsibility
//class LECTURERCABINET XUAT HIEN, CODE Y CHANG
