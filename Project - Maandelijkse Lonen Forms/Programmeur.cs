using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Maandelijkse_Lonen_Forms
{
    public class Programmeur : Werknemer
    {
        public bool Bedrijfswagen { get; set; }

        public Programmeur(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, string rijksregisternummer, DateTime indiensttreding, string functie, double aantalUren, bool bedrijfswagen, double startloon = 2200.00, int bijdragenSocialeZekerheid = 200) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, functie, aantalUren, startloon, bijdragenSocialeZekerheid)
        {
            Bedrijfswagen = bedrijfswagen;
        }
        private string functie = "Programeur";



        public override double Bedrijfsvoorheffing(double loon)
        {
            double BedrijfsvoorheffingLoon;
            if (!Bedrijfswagen)
            { BedrijfsvoorheffingLoon = loon * 0.1368; }
            else
            { BedrijfsvoorheffingLoon = loon * 0.1730; }
            return BedrijfsvoorheffingLoon;
        }



        //public override string ToString()
        //{
        //    return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\nBedrijfswagen           : {9}\n-----------------------------------------------\nStartloon               : {10}\n",
        //    DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren,Bedrijfswagen, StartloonNaUren(), AncienniteitJaren()); ;
        //}
        public override string ToString()
        {
            return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\nBedrijfswagen           : {9}\n-----------------------------------------------\nStartloon               :  € {10}\nAncienniteit            : +€ {11}\n                           € {12}\nSociale zekerheid       : -€ {13}\n                           € {14}\nBedrijf voorheffing     : -€ {15}\n                           € {16}\nTotaal                     € {17}\n-----------------------------------------------",
            DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren, Bedrijfswagen, StartloonNaUren(), Ancienniteit(), (StartloonNaUren() + Ancienniteit()), BijdragenSocialeZekerheid, (StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid, Math.Round(Bedrijfsvoorheffing(2044), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2));
        }

    }


}