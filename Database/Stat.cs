//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stat
    {
        public System.Guid StatId { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    
        public virtual AppUser AppUser { get; set; }
    }
}
