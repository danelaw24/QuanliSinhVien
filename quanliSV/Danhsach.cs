using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanliSV
{
    internal class Danhsach
    {
        private int n;
        private SInhvien[] myArr;

        public Danhsach(int n)
        {
            this.n = n;
            myArr = new SInhvien[n];
        }
        public void NhapDS()
        {
            for (int i = 0; i < n; i++)
            {
                myArr[i] = new SInhvien();
                myArr[i].NhapTT();
            }
        }

    }
}
