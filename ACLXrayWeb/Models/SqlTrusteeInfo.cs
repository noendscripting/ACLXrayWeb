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
    
    public partial class SqlTrusteeInfo
    {
        public Nullable<int> SqlInstanceId { get; set; }
        public string InstanceName { get; set; }
        public Nullable<int> LoginId { get; set; }
        public byte[] LoginSid { get; set; }
        public string LoginName { get; set; }
        public string LoginType { get; set; }
        public Nullable<int> LoginTrusteeId { get; set; }
        public Nullable<int> LoginDisabled { get; set; }
        public int LoginIsFixedRole { get; set; }
        public Nullable<int> LoginRoleMemberId { get; set; }
        public byte[] LoginRoleMemberSqlId { get; set; }
        public string LoginRoleMemberName { get; set; }
        public Nullable<int> LoginRoleMemberTrusteeId { get; set; }
        public string LoginRoleMemberType { get; set; }
        public Nullable<int> CanConnectToInstance { get; set; }
        public Nullable<int> DenyRevokeConnectToInstance { get; set; }
        public Nullable<int> HasControlServer { get; set; }
        public Nullable<int> NrInstanceGrants { get; set; }
        public Nullable<int> NrInstanceGrantWithOption { get; set; }
        public Nullable<int> NrInstanceDenyRevoke { get; set; }
        public Nullable<int> SqlDatabaseId { get; set; }
        public string DbName { get; set; }
        public byte[] OwnerSqlSid { get; set; }
        public byte[] DbUserSqlSid { get; set; }
        public Nullable<int> DbUserId { get; set; }
        public string DbUserName { get; set; }
        public string DbUserType { get; set; }
        public Nullable<int> DbUserTrusteeId { get; set; }
        public Nullable<bool> DbUserIsFixedRole { get; set; }
        public Nullable<int> DbUserRoleMemberId { get; set; }
        public byte[] DbUserRoleMemberSqlId { get; set; }
        public string DbUserRoleMemberName { get; set; }
        public Nullable<int> DbUserRoleMemberTrusteeId { get; set; }
        public string DbUserRoleMemberType { get; set; }
        public Nullable<int> CanConnectToDb { get; set; }
        public Nullable<int> DenyRevokeConnectToDb { get; set; }
        public Nullable<int> NrDbGrants { get; set; }
        public Nullable<int> NrDbGrantWithOption { get; set; }
        public Nullable<int> NrDbDenyRevoke { get; set; }
        public int IsDbOwner { get; set; }
    }
}
