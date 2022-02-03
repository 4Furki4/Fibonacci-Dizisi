using System;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri Konsol = new Konsol_Islemleri();
            fibonaccIslemleri fibonacci = new fibonaccIslemleri(); // Constructor metotlar çalıştırıldı.
            Konsol.KonsolMesajı(); // Konsola mesaj yazdıran metot çalıştırıldı.
            int genislik= Konsol.DiziGenisligiAlma(); // Dizinin genişliğini alıp döndüren metot çalıştırıldı ve genislik adlı değişkene atandı.
            int[] fibonacciDizisi= fibonacci.FibonacciDizisiOluşturma(genislik); //Fibonacci dizisini oluşturan metot çalıştırıldı ve yeni bir diziye atandı.
            int ortalama= fibonacci.FibDizisininOrtaması(fibonacciDizisi); // Fib dizisinin ortalamasını alan metot çalıştırıldı ve dönen değer yeni bir değişkene atandı.
            Konsol.OrtalamayıYazdırma(ortalama);
        }
    }
}
