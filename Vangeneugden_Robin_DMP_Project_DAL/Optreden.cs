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
    
    public partial class Optreden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Optreden()
        {
            this.GroepOptreden = new HashSet<GroepOptreden>();
            this.LidOptreden = new HashSet<LidOptreden>();
        }
    
        public int id { get; set; }
        public string omschrijving { get; set; }
        public int locatieId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroepOptreden> GroepOptreden { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LidOptreden> LidOptreden { get; set; }
        public virtual Locatie Locatie { get; set; }
    }
}
