//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    public partial class Repetitie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repetitie()
        {
            this.GroepRepetitie = new HashSet<GroepRepetitie>();
            this.LidRepetitie = new HashSet<LidRepetitie>();
        }
    
        public int id { get; set; }
        public string omschrijving { get; set; }
        public int locatieId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroepRepetitie> GroepRepetitie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LidRepetitie> LidRepetitie { get; set; }
        public virtual Locatie Locatie { get; set; }

        public override string ToString()
        {
            return omschrijving + " " + Locatie;
        }
    }
}
