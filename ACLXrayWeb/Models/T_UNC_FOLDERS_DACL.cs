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
    
    public partial class T_UNC_FOLDERS_DACL
    {
        public string ObjectSID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
        public string Info { get; set; }
        public Nullable<System.DateTime> LastAccessTime { get; set; }
        public string Access { get; set; }
        public string AccessType { get; set; }
        public Nullable<bool> IsInherited { get; set; }
        public int ID { get; set; }
        public Nullable<int> ServerID { get; set; }
        public string Owner { get; set; }
        public Nullable<bool> OwnerIsWellKnown { get; set; }
        public Nullable<bool> OwnerRightsPresent { get; set; }
        public Nullable<long> Size { get; set; }
        public string UNCServer { get; set; }
        public string UNCShare { get; set; }
    }
}
