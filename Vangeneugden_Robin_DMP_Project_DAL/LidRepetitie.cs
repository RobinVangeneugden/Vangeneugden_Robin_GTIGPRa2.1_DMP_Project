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
    
    public partial class LidRepetitie
    {
        public int id { get; set; }
        public int lidId { get; set; }
        public int repetitieId { get; set; }
    
        public virtual Lid Lid { get; set; }
        public virtual Repetitie Repetitie { get; set; }
    }
}
