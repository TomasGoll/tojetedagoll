//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TojeTedaGoll.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guest
    {
        public Guest()
        {
            this.NumPersons = 0;
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Coming { get; set; }
        public bool NotComming { get; set; }
        public bool SleepOver { get; set; }
        public int NumPersons { get; set; }
        public bool DontSleepOver { get; set; }
        public bool YesBowTie { get; set; }
        public bool NoBowTie { get; set; }
    }
}
