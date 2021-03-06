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
    
    public partial class Computer
    {
        public string Authority { get; set; }
        public string Sid { get; set; }
        public string Name { get; set; }
        public string SamAccountName { get; set; }
        public string ObjectClass { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string DistinguishedName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ComputerType { get; set; }
        public int Expr1 { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<System.DateTime> LastPasswordSet { get; set; }
        public Nullable<System.DateTime> LastLogon { get; set; }
        public bool PasswordNeverExpires { get; set; }
        public bool UserCannotChangePassword { get; set; }
        public string UPN { get; set; }
        public Nullable<int> UAC { get; set; }
        public Nullable<System.DateTime> BadPasswordTime { get; set; }
        public Nullable<System.DateTime> AccountExpires { get; set; }
        public string AllowedToDelegateTo { get; set; }
        public Nullable<System.DateTime> WhenCreated { get; set; }
        public Nullable<System.DateTime> WhenChanged { get; set; }
        public string OS { get; set; }
        public string OSServicePack { get; set; }
        public string OSVersion { get; set; }
    }
}
