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
    
    public partial class T_GPO_RESTRICTED_GROUPS
    {
        public int Id { get; set; }
        public string GPOIdentifier { get; set; }
        public string GPOName { get; set; }
        public string DomainName { get; set; }
        public string GroupName { get; set; }
        public string GroupNameSID { get; set; }
        public string Member { get; set; }
        public string MemberSID { get; set; }
        public string MemberOf { get; set; }
        public string MemberOfSID { get; set; }
        public string LinksTo { get; set; }
        public string FilterName { get; set; }
        public string FilterQuery { get; set; }
        public string ApplyGPOTo { get; set; }
        public string ApplyGPOToSID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public Nullable<int> ServerID { get; set; }
    }
}
