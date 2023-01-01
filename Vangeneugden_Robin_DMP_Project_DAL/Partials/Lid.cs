using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    public partial class Lid: BasisKlasse
    {
        public override string this[string propertynaam]
        {
            get
            {
                if (propertynaam == "id" && id > 0)
                {
                    return "De id van het bandlid dient groter te zijn als 0!";
                }
                else if (propertynaam == "id" && string.IsNullOrWhiteSpace(id.ToString()))
                {
                    return "De id van het bandlid is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "voornaam" && string.IsNullOrWhiteSpace(voornaam))
                {
                    return "Voornaam is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "familienaam" && string.IsNullOrWhiteSpace(familienaam))
                {
                    return "Familienaam is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "rijksregisternr" && string.IsNullOrWhiteSpace(rijksregisternr))
                {
                    return "Rijksregisternummer is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "straat" && string.IsNullOrWhiteSpace(straat))
                {
                    return "Straat is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "huisnummer" && string.IsNullOrWhiteSpace(huisnummer))
                {
                    return "Huisnummer is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "postcode" && string.IsNullOrWhiteSpace(postcode))
                {
                    return "Postcode is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "gemeente" && string.IsNullOrWhiteSpace(gemeente))
                {
                    return "Gemeente is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "land" && string.IsNullOrWhiteSpace(land))
                {
                    return "Land is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "telefoon" && string.IsNullOrWhiteSpace(telefoon))
                {
                    return "Telefoonnummer is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "email" && string.IsNullOrWhiteSpace(email))
                {
                    return "Emailadres is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "inschrijvingsDatum" && string.IsNullOrWhiteSpace(inschrijvingsDatum.ToString()))
                {
                    return "Inschrijvingsdatum is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "geslacht" && string.IsNullOrWhiteSpace(geslacht))
                {
                    return "Geslacht is een verplicht in te vullen veld!";
                }
                else
                {
                    return "";
                }
            }
        }
        public override string ToString()
        {
            return voornaam + " " + familienaam;
        }
    }
}
