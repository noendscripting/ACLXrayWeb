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
    
    public partial class SqlDatabasePrincipal
    {
        public int SqlDatabaseId { get; set; }
        public int SqlPrincipalId { get; set; }
        public string Name { get; set; }
        public byte[] SqlSid { get; set; }
        public Nullable<int> TrusteeId { get; set; }
        public string Type { get; set; }
        public string DefaultSchemaName { get; set; }
        public bool IsFixedRole { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public Nullable<bool> IsExpanded { get; set; }
        public Nullable<bool> IsBusy { get; set; }
    }
}
