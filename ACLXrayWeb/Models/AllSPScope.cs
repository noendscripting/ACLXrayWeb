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
    
    public partial class AllSPScope
    {
        public string ParentName { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public System.Guid ID { get; set; }
        public string ScopeTypeLabel { get; set; }
        public int ScopeType { get; set; }
        public string PrincipalName { get; set; }
        public string PrincipalDisplayName { get; set; }
        public string SPPrincipalLoginName { get; set; }
        public string PrincipalAuthority { get; set; }
        public string PrincipalLoginName { get; set; }
        public Nullable<int> PrincipalType { get; set; }
        public string PrincipalTypeLabel { get; set; }
        public string MemberName { get; set; }
        public string MemberDisplayName { get; set; }
        public string SPMemberLoginName { get; set; }
        public string MemberAuthority { get; set; }
        public string MemberLoginName { get; set; }
        public string PermissionName { get; set; }
        public string ADGroupSID { get; set; }
        public string IsDirectAdmin { get; set; }
    }
}