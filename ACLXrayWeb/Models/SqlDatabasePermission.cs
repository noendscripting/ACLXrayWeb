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
    
    public partial class SqlDatabasePermission
    {
        public int Id { get; set; }
        public int SqlDatabaseId { get; set; }
        public string Class { get; set; }
        public int MajorId { get; set; }
        public int MinorId { get; set; }
        public int GranteeId { get; set; }
        public int GrantorId { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
    }
}
