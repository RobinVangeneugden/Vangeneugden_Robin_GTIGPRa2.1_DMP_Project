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
    
    public partial class Locatie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locatie()
        {
            this.Optreden = new HashSet<Optreden>();
            this.Repetitie = new HashSet<Repetitie>();
        }
    
        public int id { get; set; }
        public string naam { get; set; }
        public string omschrijving { get; set; }
        public string straat { get; set; }
        public string huisnummer { get; set; }
        public string postcode { get; set; }
        public string gemeente { get; set; }
        public string land { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Optreden> Optreden { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repetitie> Repetitie { get; set; }
    }
}
