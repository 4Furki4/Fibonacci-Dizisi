using System;
namespace fibo
{
    public class fibonaccIslemleri
    {
        public int[] FibonacciDizisiOluşturma(int genislik)
        {
            int[] FibDizisi= new int[genislik];
            FibDizisi[0]=1;
            FibDizisi[1]=1;
            for (int i = 2; i <= FibDizisi.Length-1; i++)
            {
                FibDizisi[i]=FibDizisi[i-1]+FibDizisi[i-2];
            }
            return FibDizisi;
        }
        public int FibDizisininOrtaması(int[] ar)
        {
            int toplam=0;
            foreach (var item in ar)
            {
                toplam+=item;
            }
            return toplam/ar.Length
        }
    }
}