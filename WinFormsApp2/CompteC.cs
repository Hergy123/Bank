using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    class CompteC
    {
        public int numero { get; set; }
        public string Client { get; set; }
        public string Libelle { get; set; }
        public string Date { get; set; }
        public int Solde { get; set; }
        public string type_banque { get; set; }

        public CompteC( int num , string clie , string libel , string dat , int solde , string type)
        {
            numero = num;
            Client = clie;
            Libelle = libel;
            Date = dat;
            Solde = solde;
            type_banque = type;


        }
    }
}
