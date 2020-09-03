using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Maandelijkse_Lonen_Forms
{
    public class IT_Support : Werknemer
    {
        public IT_Support(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, string rijksregisternummer, DateTime indiensttreding, string functie, double aantalUren = 38, double startloon = 2050.00, int bijdragenSocialeZekerheid = 200) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, rijksregisternummer, aantalUren, startloon, bijdragenSocialeZekerheid)
        {

        }

        public override double Bedrijfsvoorheffing(double loon)
        {
            return base.Bedrijfsvoorheffing(loon) + 50;
        }
        public double StartloonPercent()
        {
            double startloonPercent = Startloon * 0.06;
            return startloonPercent;
        }




        public override double Ancienniteit()
        {
            int AantalJarenDienst = AncienniteitJaren();
            double Loon = Startloon - StartloonPercent();

            for (int i = 0; i < AantalJarenDienst; i++)
            {
                Loon *= 1.1;
            }
            Loon = StartloonPercent();
            return Loon;
        }










        private string functie = "IT-Support";

        public override string ToString()
        {
            return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\n-----------------------------------------------\nStartloon               :  € {9}\nAncienniteit            : +€ {10}\n                           € {11}\nSociale zekerheid       : -€ {12}\n                           € {13}\nBedrijf voorheffing     : -€ {14}\n                           € {15}\nTotaal                     € {15}\n-----------------------------------------------",
            DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren, Startloon, Ancienniteit(), (StartloonNaUren() + Ancienniteit()), BijdragenSocialeZekerheid, (StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid, Math.Round(Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round(StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2));
        }
    }
}
