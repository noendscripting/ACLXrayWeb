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
    
    public partial class T_SCAN_FILES
    {
        public int Id { get; set; }
        public string SessionGUID { get; set; }
        public string ObjectType { get; set; }
        public Nullable<System.DateTime> Import_Timestamp { get; set; }
    }
}