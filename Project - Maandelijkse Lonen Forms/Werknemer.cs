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
                return Loon - StartloonNaUren();
                //return AantalJarenDienst;
            }
            public virtual double Bedrijfsvoorheffing(double loon)
            {
                double BedrijfsvoorheffingLoon = loon * 0.1368;
                return BedrijfsvoorheffingLoon;
            }

        public virtual double Extras()
        {
            double nettoLoon = Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid));
            return nettoLoon;
        }

        //public override string tostring()
        //{
        //    return string.format("{0} {1} geslacht: {2} in dienst sinds {3} rekening nummer {4} {5} ", voornaam, achternaam, geslacht, indiensttreding.toshortdatestring());
        //)

        public string  Content()
            {
            string startloon1 = Convert.ToString(StartloonNaUren());
            DateTime datetime = DateTime.Now;

            string result = "\n-----------------------------------------------------------------------\n LOONBRIEF" + "  " + datetime.ToString("D") + "\n-----------------------------------------------------------------------\n NAAM                       : " + Voornaam + " " + Achternaam + " \n GESLACHT                  : " + Geslacht + "\n GEBOORTEDATUM             : " + GeboorteDatum + "\n RIJKSREGISTERNUMMER        : " + Rijksregisternummer + "\n DATUM INDIENSTTREDING      : " + Indiensttreding + "\n FUNCTIE                                  : " + functie + "\n AANTAL GEPRESTREERDE UREN : " + AantalUren + "/38" + "\n-----------------------------------------------------------------------\n STARTLOON                :   € " + Math.Round((StartloonNaUren()),2) + "\n ANCIENNITEIT             : +€ "  + Math.Round(Ancienniteit(),2) + "\n                                           € "+ Math.Round((StartloonNaUren()+ Ancienniteit()),2) +"\n SOCIALE ZEKERHEID   : -€"+BijdragenSocialeZekerheid +"\n                                           € "+ Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid), 2) +"\n BEDRIJF VOORHEFFING: -€ "+ Math.Round(Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)),2) +"\n                           € "+ Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2)+"\ntotaal                     € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2)+"\n-----------------------------------------------------------------------\n";
            //string result ="-----------------------------------------------\nloonbrief {0}\n-----------------------------------------------\nnaam                    : {1} {2}\ngeslacht                : {3}\ngeboortedatum           : {4}\nrijksregisternummer     : {5}\ndatum indiensttreding   : {6}\nfunctie                 : {7}\naantal gepresteerde uren: {8}/38\n-----------------------------------------------\nsartloon                :  € {9}\nancienniteit            : +€ {10}\n                           € {11}\nsociale zekerheid       : -€ {12}\n                           € {13}\nbedrijf voorheffing     : -€ {14}\n                           € {15}\ntotaal                     € {15}\n-----------------------------------------------",
            //datetime, Voornaam, Achternaam, geslacht, geboortedatum.toshortdatestring(), rijksregisternummer, indiensttreding.toshortdatestring(), functie, aantaluren, startloonnauren(), ancienniteit(), (startloonnauren() + ancienniteit()), bijdragensocialezekerheid, (startloonnauren() + ancienniteit()) - bijdragensocialezekerheid, math.round(bedrijfsvoorheffing(startloonnauren()), 2), math.round(startloonnauren() + ancienniteit() - bijdragensocialezekerheid - bedrijfsvoorheffing(startloonnauren()), 2), math.round((startloonnauren() + ancienniteit()) - bijdragensocialezekerheid - bedrijfsvoorheffing(startloonnauren()), 2));
            
            return result;
            }

        //public override string tostring()
        //{
        //    return string.format("-----------------------------------------------------------\nloonbrief {0}\n-----------------------------------------------\nnaam                    : {1} {2}\ngeslacht                : {3}\ngeboortedatum           : {4}\nrijksregisternummer     : {5}\ndatum indiensttreding   : {6}\nfunctie                 : {7}\naantal gepresteerde uren: {8}/38\n-----------------------------------------------\nsartloon                :  € {9}\nancienniteit            : +€ {10}\n                           € {11}\nsociale zekerheid       : -€ {12}\n                           € {13}\nbedrijf voorheffing     : -€ {14}\n                           € {15}\ntotaal                     € {15}\n-----------------------------------------------",
        //    datetime.now.toshortdatestring(), voornaam, achternaam, geslacht, geboortedatum.toshortdatestring(), rijksregisternummer, indiensttreding.toshortdatestring(), functie, aantaluren, startloonnauren(), ancienniteit(), (startloonnauren() + ancienniteit()), bijdragensocialezekerheid, (startloonnauren() + ancienniteit()) - bijdragensocialezekerheid, math.round(bedrijfsvoorheffing(startloonnauren()), 2), math.round(startloonnauren() + ancienniteit() - bijdragensocialezekerheid - bedrijfsvoorheffing(startloonnauren()), 2), math.round((startloonnauren() + ancienniteit()) - bijdragensocialezekerheid - bedrijfsvoorheffing(startloonnauren()), 2));
        //}
        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
        }
    }


