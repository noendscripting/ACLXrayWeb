//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACLXrayWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AdminCountReport
    {
        public string ServerFqdn { get; set; }
        public string CanBeDelegated { get; set; }
        public string Name { get; set; }
        public string Authority { get; set; }
        public string ObjectClass { get; set; }
        public string SamAccountName { get; set; }
        public string DistinguishedName { get; set; }
        public string ObjectSID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public Nullable<System.DateTime> WhenCreated { get; set; }
        public Nullable<System.DateTime> WhenChanged { get; set; }
    }
}
