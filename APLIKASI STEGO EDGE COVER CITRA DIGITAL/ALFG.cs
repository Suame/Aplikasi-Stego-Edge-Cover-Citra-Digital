using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL
{
    class ALFG
    {
        public int n;
        public ALFG(int n)
        {
            this.n = n;
        }

        private int fibo(int i)
        {
            if (i < 2)
                return i;
            else
                return fibo(i - 1) + fibo(i - 2);            
        }

        public int PRNG (int j, int k, int m)
        {
            int Fibo = (fibo(n - j) + fibo(n - k)) % (int)Math.Pow(2,m);
            return Fibo;
        }

    }
}
