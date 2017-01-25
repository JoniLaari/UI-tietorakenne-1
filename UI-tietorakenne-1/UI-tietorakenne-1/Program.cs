using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri()
        {
            //Luodaan muutama testihenkilö
            Henkilot poppoo = new JAMK_IT.Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Pekka", Sukunimi = "Black", Hetu = "311270-123E" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Pepe", Sukunimi = "Kekson", Hetu = "010505-888K" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Jorma", Sukunimi = "Hirvonen", Hetu = "090353-R15U" };
            // lisataan henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            //Tulostetaan poppoo näytölle
            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("Henkilo {0}", h.ToString());
            }
            // TODO kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle
            string key = "090353-R15U";
            if (Henkilo.ContainsKey(key))
            {
                Console.Write("Henkilö jonka hetu on {0} on {1}");
            }
                
        }
    }
}
