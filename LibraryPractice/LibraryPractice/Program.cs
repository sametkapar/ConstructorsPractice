using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library kutuphane = new Library();

            #region Kullanıcı adı kontrol.


            Console.WriteLine("Kullanıcı adınızı giriniz");
            string kadi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string sifre = Console.ReadLine();

            kutuphane.UserCheck(kadi, sifre);


            #endregion


        }
    }
}
