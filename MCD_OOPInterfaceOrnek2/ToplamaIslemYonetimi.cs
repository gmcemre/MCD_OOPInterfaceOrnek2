using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class ToplamaIslemYonetimi : Islem, Iislem
    {
        void Iislem.IslemAdiniGetir()
        {
            Console.WriteLine(IslemTur+"-->");
        }

        void Iislem.IslemYap()
        {
            KullanicidanSayiAlveTopla();
        }

        private void KullanicidanSayiAlveTopla()
        {
            Console.WriteLine("Sayı 1: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı 1: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı 1: ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç: "+(s1 +s2+s3));

        }

        public ToplamaIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Toplama;
        }
    }
}
