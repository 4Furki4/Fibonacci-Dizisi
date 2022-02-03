using System;
namespace fibo
{
    public class fibonaccIslemleri
    {
        public int[] FibonacciDizisiOluşturma(int genislik) //genislik Konsol_Islemleri sınıfındaki DiziGenisliğiAlma metodundan alınacak.
        {
            int[] FibDizisi= new int[genislik];
            FibDizisi[0]=1; // birinci ve ikinci değeri önceden atıyorum ki alltaki for döngüsünde kullandığım formülde sorun çıkmasın.
            FibDizisi[1]=1;
            for (int i = 2; i <= FibDizisi.Length-1; i++)
            {
                FibDizisi[i]=FibDizisi[i-1]+FibDizisi[i-2]; //Fib dizisinin matığıyla bir dizi yardımıyla 2 önceki sayının toplamıyla sıradaki sayıyı atıyoruz.
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
            return toplam/ar.Length;
        }
        
    }
}