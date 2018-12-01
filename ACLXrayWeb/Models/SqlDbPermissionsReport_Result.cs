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
    
    public partial class SqlDbPermissionsReport_Result
    {
        public Nullable<int> AdUserId { get; set; }
        public string AdUserAuthority { get; set; }
        public string AdUserName { get; set; }
        public string AdUserDisplayName { get; set; }
        public Nullable<int> LoginDisabled { get; set; }
        public int HasInstanceDirectPermission { get; set; }
        public int HasDbDirectPermission { get; set; }
        public Nullable<int> CanConnectToInstance { get; set; }
        public Nullable<int> DenyRevokeConnectToInstance { get; set; }
        public Nullable<int> CanConnectToDb { get; set; }
        public Nullable<int> DenyRevokeConnectToDb { get; set; }
        public Nullable<int> HasControlServer { get; set; }
        public Nullable<int> LoginIsFixedRole { get; set; }
        public Nullable<int> DirectLoginIsFixedRole { get; set; }
        public Nullable<int> DirectHasControlServer { get; set; }
        public Nullable<int> DirectNrInstanceGrants { get; set; }
        public Nullable<int> DirectNrInstanceGrantWithOption { get; set; }
        public Nullable<int> NrInstanceDenyRevoke { get; set; }
        public Nullable<int> DirectDbUserIsFixedRole { get; set; }
        public Nullable<int> DirectNrDbGrants { get; set; }
        public Nullable<int> DirectNrDbGrantWithOption { get; set; }
        public Nullable<int> DirectNrDbDenyRevoke { get; set; }
        public Nullable<int> IsDbOwner { get; set; }
    }
}
