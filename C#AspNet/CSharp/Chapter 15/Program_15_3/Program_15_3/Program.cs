using System;


namespace Program_15_3
{
    class Matrix
    {
        int[,] a = new int[5, 5];
        public static Matrix operator +(Matrix m, Matrix n)
        {
            Matrix c = new Matrix();
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    c.a[i, j] = m.a[i, j] + n.a[i, j];
            return c;
        }
        public static Matrix operator -(Matrix m, Matrix n)
        {
            Matrix c = new Matrix();
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    c.a[i, j] = m.a[i, j] + n.a[i, j];
            return c;
        }
        public static Matrix operator *(Matrix x, Matrix y)
        {
            int m = 0, n = 0;
            Matrix z = new Matrix();
            z.a[m, n] = 0;
            while (m < 5)
                while (n < 5)
                    for (int i = 0; i < 5; ++i)
                        z.a[m, n] += z.a[m, n] = (x.a[m, i] * y.a[i, n]);
            return z;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
