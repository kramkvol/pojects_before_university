using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Mnojestva
    {
        int[] a;
        int length;
        public Mnojestva(int size)
        {
            a = new int[size];
            length = size;
        }
        public Mnojestva(params int[] num)
        {
            length = num.Length;
            a = new int[length];
            for (int i = 0; i < num.Length; i++) { a[i] = num[i]; }
        }
        public static Mnojestva operator + (Mnojestva [] a, Mnojestva [] b)
        {
            int[] nums1 = { };
            int len = a.Length < b.Length ? a.Length : b.Length;
            Mnojestva temp = new Mnojestva(len);
            for (int i = 0; i < len; i++)
            {
                Array.Copy(a., nums1, nums1.Length);
            }
            for (int j = 0; j < len; j++)
            {
                Array.Copy(b, nums1, nums1.Length + 1);
            }
            for (int k = 0; k < nums1.Length; k++)
                temp[k] = nums1[k];
                return temp;
        }
        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < length)
                {
                    return a[i];
                }
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < length)
                {
                    a[i] = value;
                }
                else throw new IndexOutOfRangeException();
            }
        }
        public void Print(string name)
        {
            Console.WriteLine(name + ": ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
