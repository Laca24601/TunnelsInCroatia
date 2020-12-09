using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TunnelsInCroatia
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader TunnelOlvas = new StreamReader("croatia.txt", Encoding.Default);
            string NevFejlec = TunnelOlvas.ReadLine();
            List<Tunnel> Alagut = new List<Tunnel>();
            while (!TunnelOlvas.EndOfStream)
            {
                string Sor = TunnelOlvas.ReadLine();
                string[] SorElemek = Sor.Split(';');
                Alagut.Add(new Tunnel(SorElemek[0],Convert.ToInt32(SorElemek[1]), SorElemek[2], SorElemek[3], SorElemek[4]));            }
            TunnelOlvas.Close();
            int Ketkm = 0;
            for (int i = 0; i < Alagut.Count; i++)
            {
                if(Alagut[i].Hosszusag > 2000)

                {
                    Ketkm++;
                }
            }

            Console.WriteLine("2. feladat: Alagutak száma:"+Ketkm+"db");
        }

    }
    class Tunnel
    {
        public string Nev;
        public int Hosszusag;
        public string Datum;
        public string Megye;
        public string Autopalya;
        public Tunnel(string Nev, int Hosszusag, string Datum, string Megye, string Autopalya)
        {
            this.Nev = Nev;
            this.Hosszusag = Hosszusag;
            this.Datum = Datum;
            this.Megye = Megye;
            this.Autopalya = Autopalya;
        }
    }
}
