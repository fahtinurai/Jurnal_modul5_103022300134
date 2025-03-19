using System;

class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        dynamic n1 = (dynamic)nilai1;
        dynamic n2 = (dynamic)nilai2;
        dynamic n3 = (dynamic)nilai3;
        dynamic terbesar = n1;

        if (n2 > terbesar)
        {
            terbesar = n2;
        }
        if (n3 > terbesar)
        {
            terbesar = n3;
        }
        return terbesar;
    }
    class program
    {
        static void Main()
        {
            PemrosesData proses = new PemrosesData();
            Console.WriteLine("nilai terbesar adalah = " + proses.DapatkanNilaiTerbesar(10.3, 30.4, 22.5));
        }
    }
}

