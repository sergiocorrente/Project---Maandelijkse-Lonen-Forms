using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Maandelijkse_Lonen_Forms
{
    class Customer_Support : Werknemer
    {


        public Customer_Support(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, string rijksregisternummer, DateTime indiensttreding, string functie, double aantalUren = 38, double startloon = 2050.00, int bijdragenSocialeZekerheid = 200) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, rijksregisternummer, aantalUren, startloon, bijdragenSocialeZekerheid)
        {
        }

     

        public override double Extras()
        {
            return base.Extras() + 50 + 19.50;
        }

        private string functie = "Customer Support";
        public string Content()
        {
            string startloon1 = Convert.ToString(StartloonNaUren());
            DateTime datetime = DateTime.Now;

            string result = "\n-----------------------------------------------------------------------\n LOONBRIEF" + "  " + datetime.ToString("D") + "\n-----------------------------------------------------------------------\n NAAM                       : " + Voornaam + " " + Achternaam + " \n GESLACHT                  : " + Geslacht + "\n GEBOORTEDATUM             : " + GeboorteDatum + "\n RIJKSREGISTERNUMMER        : " + Rijksregisternummer + "\n DATUM INDIENSTTREDING      : " + Indiensttreding + "\n FUNCTIE                                  : " + functie + "\n AANTAL GEPRESTREERDE UREN : " + AantalUren + "/38" + "\n EXTRA                                : " + Extras() + "\n-----------------------------------------------------------------------\n STARTLOON                :   € " + Math.Round((StartloonNaUren()), 2) + "\n ANCIENNITEIT             : +€ " + Math.Round(Ancienniteit(), 2) + "\n                                           € " + Math.Round((StartloonNaUren() + Ancienniteit()), 2) + "\n SOCIALE ZEKERHEID   : -€" + BijdragenSocialeZekerheid + "\n                                           € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid), 2) + "\n BEDRIJF VOORHEFFING: -€ " + Math.Round(Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\n                           € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\ntotaal                     € " + Math.Round((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid) - Bedrijfsvoorheffing((StartloonNaUren() + Ancienniteit() - BijdragenSocialeZekerheid)), 2) + "\n-----------------------------------------------------------------------\n";

            return result;
        }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }

    }
}

