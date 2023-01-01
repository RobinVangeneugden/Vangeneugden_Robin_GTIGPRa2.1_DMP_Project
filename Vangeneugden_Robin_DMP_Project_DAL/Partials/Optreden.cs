using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    public partial class Optreden: BasisKlasse
    {

        public override string this[string propertynaam]
        {
            get
            {
                if (propertynaam == "omschrijving" && string.IsNullOrWhiteSpace(omschrijving))
                {
                    return "Omschrijving is een verplicht in te vullen veld!";
                }
                else
                {
                    return "";
                }
            }
        }
        public override string ToString()
        {
            return omschrijving + " " + Locatie;
        }
    }
}
