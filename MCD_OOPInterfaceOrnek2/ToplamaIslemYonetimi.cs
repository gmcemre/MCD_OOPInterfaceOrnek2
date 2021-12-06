using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class ToplamaIslemYonetimi : Islem, Iislem
    {
        public void IslemAdiniGetir()
        {
            Console.WriteLine(IslemTur+"-->");
        }

        public void IslemYap()
        {
            KullanicidanSayiAlveTopla();
        }

        private void KullanicidanSayiAlveTopla()
        {
            Console.WriteLine("Sayı 1: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı 2: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı 3: ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sonuç: "+(s1 +s2+s3));

        }

        public ToplamaIslemYonetimi()
        {
            this.IslemTur = IslemTuru.Toplama;
        }
    }
}
