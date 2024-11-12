using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalloda_GUI_20241107
{
    internal class Vendegek
    {
        string nev;
        int ejszam;
        int venszam;
        string ellatas;

        public string Nev { get => nev; set => nev = value; }
        public int Ejszam { get => ejszam; set => ejszam = value; }
        public int Venszam { get => venszam; set => venszam = value; }
        public string Ellatas { get => ellatas; set => ellatas = value; }

        public Vendegek(string sor)
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            ejszam = Convert.ToInt32(darabok[1]);
            venszam = Convert.ToInt32(darabok[2]);
            Ellatas = darabok[3];
        }

        public int VendegEjszakakSzamitas()
        {
            return ejszam * venszam;
        }
    }

}
