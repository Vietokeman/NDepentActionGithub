using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Entites
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString() => $"{Id} | {Name} | {Yob} | {Gpa}";
    }
}
//ta can luu tru nhieu ho so sinh vien
//luu tru nhieu ho so sinh vien thi can khai bao mang
//Student[] arr = new Student[500]
//int count=0; //count++ thoe dan nhung ho so sv dc cat vao 
//mang va bien count khai bao o dau
//nguyen ly S trong solid: moi class chi lam dung viec cua minh
//Student da lam tron viec: luu ho so tung ban, tuc new student() co trong ram
//cho nao cat nhieu ho so -> ko phai cau cchuyen cua class student
//cai tu de dung ho so
//no co du cai khai niem crud ho so: CREATE//INSERT THEM
//                                   RETRIEVE/READ  LAY TOAN BO, IN SAO KE
//                                   UPDATE
//                                   DELETE

// TU DUNG HO SO, TU DUNG BALO GIO XACH O SIEU THI -> QUAY GOI TEN LA DICH VU KHACH HANG -> SERVICE
