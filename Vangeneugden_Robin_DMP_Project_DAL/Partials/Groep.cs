using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    public partial class Groep: BasisKlasse
    {
        public override string this[string propertynaam]
        {
            get
            {
                if (propertynaam == "naam" && string.IsNullOrWhiteSpace(naam))
                {
                    return "Naam is een verplicht in te vullen veld!";
                }
                else if (propertynaam == "omschrijving" && string.IsNullOrWhiteSpace(omschrijving))
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
            return naam;
        }
    }
}
