using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJLinkedList
{
    class QuanLiSV
    {
        protected Node First;
        public QuanLiSV()
        {
            First = null;
        }
        public void AddFirst(SinhVien X)
        {
            if (X == null) return;
            Node newNode = new Node(X);
            if (First == null)
                First = newNode;
            else
            {
                newNode.Next = First;
                First = newNode;
            }
        }
        public void AddLast(SinhVien X)
        {
            if (X == null) return;
            Node newNode = new Node(X);
            if (First == null)
                First = newNode;
            else
            {
                Node curNode = First;
                while (curNode.Next != null)
                    curNode = curNode.Next;
                curNode.Next = newNode;
            }
        }
        public Node AddAfter(SinhVien X, string Y)
        {
            if (X == null || Y == null || First == null) return null;
            Node curNode = First;
            while (curNode.Value.MSSV!=Y && curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            if (curNode.Value.MSSV!=Y)
                return null;
            else
            {
                Node newNode = new Node(X);
                newNode.Next = curNode.Next;
                curNode.Next = newNode;
                return newNode;
            }

        }
        public Node AddBefore(SinhVien X, string V)
        {
            if (X == null || First == null || V == null) return null;

            if (First.Value.MSSV==V)
            {
                Node newNode = new Node(X);
                newNode.Next = First;
                First = newNode;
                return newNode;
            }

            Node prevNode = null;
            Node curNode = First;

            while (curNode != null && curNode.Value.MSSV!=V)
            {
                prevNode = curNode;
                curNode = curNode.Next;
            }

            if (curNode == null) return null;

            Node newNodeBefore = new Node(X);
            prevNode.Next = newNodeBefore;
            newNodeBefore.Next = curNode;
            return newNodeBefore;
        }
        public Node InsertBetween(SinhVien X, string V1, string V2)
        {
            if (X == null || First == null || V1 == null || V2 == null)
                return null;

            Node curNode = First;


            while (curNode != null && curNode.Value.MSSV!=V1)
            {
                curNode = curNode.Next;
            }


            if (curNode == null || curNode.Next == null || curNode.Next.Value.MSSV!=V2)
            {
                return null;
            }


            Node newNode = new Node(X);
            newNode.Next = curNode.Next;
            curNode.Next = newNode;

            return newNode;
        }
        public Node Find(string V)
        {
            if (First == null || V == null) return null;
            Node curNode = First;
            while (curNode.Next != null && curNode.Value.MSSV!=V)
            {
                curNode = curNode.Next;
            }
            if (curNode.Value.MSSV == V)
                return curNode;
            else
                return null; 
        }
        public void PrintList()
        {
            if (First == null)
            {
                Console.WriteLine("Danh Sach Rong");
                return;
            }
            Node curNode = First;
            while (curNode != null)
            {
                Console.Write(curNode.Value);
                if (curNode.Next != null)
                    Console.Write("\n");
                curNode = curNode.Next;
            }

        }
    }
}
