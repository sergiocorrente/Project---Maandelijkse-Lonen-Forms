using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Maandelijkse_Lonen_Forms
{

        public class Werknemer
        {

            public string Voornaam { get; set; }

            public string Achternaam { get; set; }
            public String Geslacht { get; set; }
            public DateTime GeboorteDatum { get; set; }
            public string Rijksregisternummer { get; set; }
            public DateTime Indiensttreding { get; set; }
            // public string IbanNummer { get; set; }
            public string Functie { get; }
            public double AantalUren { get; set; }
            public double Startloon { get; }
            public int BijdragenSocialeZekerheid { get; }
            public Werknemer(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, string rijksregisternummer, DateTime indiensttreding, string functie, double aantalUren, double startloon = 1900.00, int bijdragenSocialeZekerheid = 200)
            {
                Voornaam = voornaam;
                Achternaam = achternaam;
                Geslacht = geslacht;
                GeboorteDatum = geboortedatum;
                Rijksregisternummer = rijksregisternummer;
                Indiensttreding = indiensttreding;
                Functie = functie;
                AantalUren = aantalUren;
                Startloon = startloon;
                BijdragenSocialeZekerheid = bijdragenSocialeZekerheid;



            }

            private string functie = "Standaard";

            public int AncienniteitJaren()
            {
                int AncienniteidJaren = DateTime.Now.Year - Indiensttreding.Year;
                return AncienniteidJaren;
            }
            public double StartloonNaUren()
            {

                double StartloonNaUren = (AantalUren / 38) * Startloon;

                return StartloonNaUren;
            }


            public virtual double Ancienniteit()
            {
                int AantalJarenDienst = AncienniteitJaren();
                double Loon = StartloonNaUren();

                for (int i = 0; i < AantalJarenDienst; i++)
                {
                    Loon *= 1.01;
                }
                //Loon -= BijdragenSocialeZekerheid;
                return Math.Round(Loon - StartloonNaUren(), 2);
                //return AantalJarenDienst;
            }
            public virtual double Bedrijfsvoorheffing(double loon)
            {
                double BedrijfsvoorheffingLoon = loon * 0.1368;
                return BedrijfsvoorheffingLoon;
            }

        //public override string ToString()
        //{
        //    return string.Format("{0} {1} geslacht: {2} in dienst sinds {3} rekening nummer {4} {5} ", voornaam, achternaam, geslacht, indiensttreding.toshortdatestring());
        //)



        //public override string ToString()
        //{
        //    return string.Format("-----------------------------------------------\nLOONBRIEF {0}\n-----------------------------------------------\nNaam                    : {1} {2}\nGeslacht                : {3}\nGeboortedatum           : {4}\nRijksregisternummer     : {5}\nDatum indiensttreding   : {6}\nFunctie                 : {7}\nAantal gepresteerde uren: {8}/38\n-----------------------------------------------\nSartloon                :  € {9}\nAncienniteit            : +€ {10}\n                           € {11}\nSociale zekerheid       : -€ {12}\n                           € {13}\nBedrijf voorheffing     : -€ {14}\n                           € {15}\nTotaal                     € {15}\n-----------------------------------------------",
        //    DateTime.Now.ToShortDateString(), Voornaam, Achternaam, Geslacht, GeboorteDatum.ToShortDateString(), Rijksregisternummer, Indiensttreding.ToShortDateString(), functie, AantalUren, StartloonNaUren(), Ancienniteit(), (StartloonNaUren() + Ancienniteit()), BijdragenSocialeZekerheid, (StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid, Math.Round(Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round(StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2), Math.Round((StartloonNaUren() + Ancienniteit()) - BijdragenSocialeZekerheid - Bedrijfsvoorheffing(StartloonNaUren()), 2));
        //}
        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
        }
    }


