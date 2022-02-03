using System;
namespace fibo
{
    public class Konsol_Islemleri
    {
        public void KonsolMesajı()
        {
            Console.Write("Lütfen fibonacci dizisi için integer değerinde bir genişlik giriniz :");
        }
        public int DiziGenisligiAlma()
        {
            int genislik=int.Parse(Console.ReadLine());
            return genislik;
        }
        public void OrtalamayıYazdırma(int ortalama)
        {
            Console.WriteLine($"Girdiğiniz genişlikle oluşturulan fibonacci dizisinin ortalaması {ortalama} olarak hesaplanmıştır.");
        }
    }
}