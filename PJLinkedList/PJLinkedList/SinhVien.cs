using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLinkedList
{
    class SinhVien
    {
        public string Ten { get; set; }
        public string MSSV { get; set; }
        public string Diem { get; set; }

        public SinhVien(string ten, string mssv, string diem)
        {
            Ten = ten;
            MSSV = mssv;
            Diem = diem;
        }
        public override string ToString()
        {
            return $"MSSV: {MSSV}, Ten: {Ten},  Diem:{Diem}";
        }
    }

    class Node
    {
        public SinhVien Value;
        public Node Next;

        public Node(SinhVien value)
        {
            Value = value;
            Next = null;
        }

    }
}
