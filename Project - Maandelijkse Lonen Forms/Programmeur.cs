using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Maandelijkse_Lonen_Forms
{
    public class Programmeur : Werknemer
    {
       string Bedrijfswagen { get; set; }

        public Programmeur(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, string rijksregisternummer, DateTime indiensttreding, string functie, double aantalUren, string bedrijfswagen, double startloon = 2200.00, int bijdragenSocialeZekerheid = 200) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, functie, aantalUren, startloon, bijdragenSocialeZekerheid)
        {
            Bedrijfswagen = bedrijfswagen;
        }
        private string functie = "Programeur";

        public override double Bedrijfsvoorheffing(double loon)
        {
            double BedrijfsvoorheffingLoon;
            if (Bedrijfswagen=="Ja")
            { BedrijfsvoorheffingLoon = loon * 0.1730; }
            else
            { BedrijfsvoorheffingLoon = loon * 0.1368; }
            return BedrijfsvoorheffingLoon;
        }

        public string Content()
        {
            string startloon1 = Convert.ToString(StartloonNaUren());
            DateTime datetime = DateTime.Now;

            string result = "\n-----------------------------------------------------------------------\n LOONBRIEF" + "  " + datetime.ToString("D") + "\n-----------------------------------------------------------------------\n NAAM                       : " + Voornaam + " " + Achternaam + " \n GESLACHT                  : " + Geslacht + "\n GEBOORTEDATUM             : " + GeboorteDatum + "\n RIJKSREGISTERNUMMER        : " + Rijksregisternummer + "\n DATUM INDIENSTTREDING      : " + Indiensttreding + "\n FUNCTIE                                  : " + functie + "\n AANTAL GEPRESTREERDE UREN : " + AantalUren + "/38" +"\n BEDRiJFWAGEN                           : "+ Bedrijfswagen+"\n-----------------------------------------------------------------------\n STARTLOON                :   € " + Math.Round((StartloonNaUren()), 2) + "\n ANCIENNITEIT             : +€ " + Math.Round(Ancienniteit(), 2) + "\n                                           € " + Math.Round((StartloonNaUren() + Ancienniteit()), 2) + "\n SOCIALE ZEKERHEID   : -€" + BijdragenSocialeZekerheid + "\n                                           € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid), 2) + "\n BEDRIJF VOORHEFFING: -€ " + Math.Round(Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\n                           € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\ntotaal                     € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\n-----------------------------------------------------------------------\n";

            return result;
        }

        //public override string ToString()
        //{
        //    return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\nBedrijfswagen           : {9}\n-----------------------------------------------\nStartloon               : {10}\n",
        //    DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren,Bedrijfswagen, StartloonNaUren(), AncienniteitJaren()); ;
        //}
        //public override string ToString()
        //{
        //    return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\nBedrijfswagen           : {9}\n-----------------------------------------------\nStartloon               :  € {10}\nAncienniteit            : +€ {11}\n                           € {12}\nSociale zekerheid       : -€ {13}\n                           € {14}\nBedrijf voorheffing     : -€ {15}\n                           € {16}\nTotaal                     € {17}\n-----------------------------------------------",
        //    DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren, Bedrijfswagen, StartloonNaUren(), Ancienniteit(), (StartloonNaUren() + Ancienniteit()), BijdragenSocialeZekerheid, (StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid, Math.Round(Bedrijfsvoorheffing(2044), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2));
        //}

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
    }
}