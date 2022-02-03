using System;
namespace fibo
{
    public class Konsol_Islemleri
    {
        public void KonsolMesajı()
        {
            Console.WriteLine("Lütfen fibonacci dizisi için integer değerinde bir genişlik giriniz.");
        }
        public int DiziGenisligiAlma()
        {
            int genislik=int.Parse(Console.ReadLine());
            return genislik;
        }
    }
}