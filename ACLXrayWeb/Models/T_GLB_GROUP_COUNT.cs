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
    
    public partial class T_GLB_GROUP_COUNT
    {
        public int Id { get; set; }
        public string GroupDN { get; set; }
        public string GroupScope { get; set; }
        public Nullable<int> GroupCount { get; set; }
        public Nullable<int> GlobalCount { get; set; }
        public Nullable<int> LocalCount { get; set; }
        public Nullable<int> UniversalCount { get; set; }
        public Nullable<int> SIDHistoryCount { get; set; }
        public Nullable<int> EstTokenSize { get; set; }
        public Nullable<bool> LoopDetected { get; set; }
        public string LoopDetectedOn { get; set; }
        public Nullable<int> ServerID { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    }
}