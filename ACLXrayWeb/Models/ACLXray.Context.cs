﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ACLXRAYEntities : DbContext
    {
        public ACLXRAYEntities()
            : base("name=ACLXRAYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AD_CONFIG> AD_CONFIG { get; set; }
        public virtual DbSet<AD_DOMAIN_ROOT> AD_DOMAIN_ROOT { get; set; }
        public virtual DbSet<AD_OBJECT_ACCESS> AD_OBJECT_ACCESS { get; set; }
        public virtual DbSet<AD_OBJECT_AUDIT> AD_OBJECT_AUDIT { get; set; }
        public virtual DbSet<ADMIN_COUNT> ADMIN_COUNT { get; set; }
        public virtual DbSet<ADMIN_SDHOLDER> ADMIN_SDHOLDER { get; set; }
        public virtual DbSet<ALL_DRIVERS> ALL_DRIVERS { get; set; }
        public virtual DbSet<AllGroupsInfo> AllGroupsInfoes { get; set; }
        public virtual DbSet<AllSPScope> AllSPScopes { get; set; }
        public virtual DbSet<AllUsersInfo> AllUsersInfoes { get; set; }
        public virtual DbSet<AZURE_DIRECTORY_ROLES> AZURE_DIRECTORY_ROLES { get; set; }
        public virtual DbSet<CA> CAs { get; set; }
        public virtual DbSet<CA_ENROLLMENT_RIGHTS> CA_ENROLLMENT_RIGHTS { get; set; }
        public virtual DbSet<CA_MANAGER_RIGHTS> CA_MANAGER_RIGHTS { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<DCOM_DACL> DCOM_DACL { get; set; }
        public virtual DbSet<DomainController> DomainControllers { get; set; }
        public virtual DbSet<EMPTY_GROUPS> EMPTY_GROUPS { get; set; }
        public virtual DbSet<EXCHANGE_DACL> EXCHANGE_DACL { get; set; }
        public virtual DbSet<EXCHANGE_MAILBOX> EXCHANGE_MAILBOX { get; set; }
        public virtual DbSet<FILE_ASSOC> FILE_ASSOC { get; set; }
        public virtual DbSet<FILES_DACL> FILES_DACL { get; set; }
        public virtual DbSet<FILES_SACL> FILES_SACL { get; set; }
        public virtual DbSet<FOLDERS_DACL> FOLDERS_DACL { get; set; }
        public virtual DbSet<FOLDERS_SACL> FOLDERS_SACL { get; set; }
        public virtual DbSet<GPO> GPOes { get; set; }
        public virtual DbSet<GroupExpandedGroup> GroupExpandedGroups { get; set; }
        public virtual DbSet<GroupExpandedPrincipal> GroupExpandedPrincipals { get; set; }
        public virtual DbSet<GroupMember> GroupMembers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<KRBTGT_ATTRIBUTES> KRBTGT_ATTRIBUTES { get; set; }
        public virtual DbSet<LAST_LOGOFF> LAST_LOGOFF { get; set; }
        public virtual DbSet<LOCAL_GROUPS> LOCAL_GROUPS { get; set; }
        public virtual DbSet<LOCAL_SIDS> LOCAL_SIDS { get; set; }
        public virtual DbSet<NTFS_DACL> NTFS_DACL { get; set; }
        public virtual DbSet<NTFS_SACL> NTFS_SACL { get; set; }
        public virtual DbSet<ORPHANED_SIDS> ORPHANED_SIDS { get; set; }
        public virtual DbSet<Principal> Principals { get; set; }
        public virtual DbSet<PROCESS_INFO> PROCESS_INFO { get; set; }
        public virtual DbSet<REGISTRY_DACL> REGISTRY_DACL { get; set; }
        public virtual DbSet<REGISTRY_LAST_LOGOFF> REGISTRY_LAST_LOGOFF { get; set; }
        public virtual DbSet<REGISTRY_PROFILES> REGISTRY_PROFILES { get; set; }
        public virtual DbSet<REGISTRY_SACL> REGISTRY_SACL { get; set; }
        public virtual DbSet<RODC_DATA> RODC_DATA { get; set; }
        public virtual DbSet<SCHEMA_DACL> SCHEMA_DACL { get; set; }
        public virtual DbSet<SERVER_INFO> SERVER_INFO { get; set; }
        public virtual DbSet<SERVICE> SERVICEs { get; set; }
        public virtual DbSet<SHARE_CONTENT_DACL> SHARE_CONTENT_DACL { get; set; }
        public virtual DbSet<SHARE_CONTENT_SACL> SHARE_CONTENT_SACL { get; set; }
        public virtual DbSet<SHARE_DACL> SHARE_DACL { get; set; }
        public virtual DbSet<SID_HISTORY> SID_HISTORY { get; set; }
        public virtual DbSet<SidHistory> SidHistories { get; set; }
        public virtual DbSet<SIGNED_DRIVERS> SIGNED_DRIVERS { get; set; }
        public virtual DbSet<SOFTWARE> SOFTWAREs { get; set; }
        public virtual DbSet<SP_Principals> SP_Principals { get; set; }
        public virtual DbSet<SP_PrincipalsAssignments> SP_PrincipalsAssignments { get; set; }
        public virtual DbSet<SP_PrincipalsPrincipals> SP_PrincipalsPrincipals { get; set; }
        public virtual DbSet<SP_RoleAssignments> SP_RoleAssignments { get; set; }
        public virtual DbSet<SP_RoleBindings> SP_RoleBindings { get; set; }
        public virtual DbSet<SP_RoleDefinitions> SP_RoleDefinitions { get; set; }
        public virtual DbSet<SP_Scopes> SP_Scopes { get; set; }
        public virtual DbSet<SP_ScopesAssignments> SP_ScopesAssignments { get; set; }
        public virtual DbSet<SPN> SPNs { get; set; }
        public virtual DbSet<SqlDatabaseObject> SqlDatabaseObjects { get; set; }
        public virtual DbSet<SqlDatabasePermission> SqlDatabasePermissions { get; set; }
        public virtual DbSet<SqlDatabasePrincipal> SqlDatabasePrincipals { get; set; }
        public virtual DbSet<SqlDatabaseRoleExpandedMember> SqlDatabaseRoleExpandedMembers { get; set; }
        public virtual DbSet<SqlDatabaseRoleMember> SqlDatabaseRoleMembers { get; set; }
        public virtual DbSet<SqlDatabas> SqlDatabases { get; set; }
        public virtual DbSet<SqlInstancePermission> SqlInstancePermissions { get; set; }
        public virtual DbSet<SqlInstancePrincipal> SqlInstancePrincipals { get; set; }
        public virtual DbSet<SqlInstanceRoleExpandedMember> SqlInstanceRoleExpandedMembers { get; set; }
        public virtual DbSet<SqlInstanceRoleMember> SqlInstanceRoleMembers { get; set; }
        public virtual DbSet<SqlInstance> SqlInstances { get; set; }
        public virtual DbSet<SqlTrusteeInfo> SqlTrusteeInfoes { get; set; }
        public virtual DbSet<SqlTrusteeInfoAdExpanded> SqlTrusteeInfoAdExpandeds { get; set; }
        public virtual DbSet<T_AD_CONFIG> T_AD_CONFIG { get; set; }
        public virtual DbSet<T_AD_DOMAIN_ROOT> T_AD_DOMAIN_ROOT { get; set; }
        public virtual DbSet<T_AD_OBJECT_ACCESS> T_AD_OBJECT_ACCESS { get; set; }
        public virtual DbSet<T_AD_OBJECT_AUDIT> T_AD_OBJECT_AUDIT { get; set; }
        public virtual DbSet<T_ADMIN_COUNT> T_ADMIN_COUNT { get; set; }
        public virtual DbSet<T_ADMIN_SDHOLDER> T_ADMIN_SDHOLDER { get; set; }
        public virtual DbSet<T_ALL_DRIVERS> T_ALL_DRIVERS { get; set; }
        public virtual DbSet<T_AZURE_DIRECTORY_ROLES> T_AZURE_DIRECTORY_ROLES { get; set; }
        public virtual DbSet<T_CA> T_CA { get; set; }
        public virtual DbSet<T_CA_ENROLLMENT_RIGHTS> T_CA_ENROLLMENT_RIGHTS { get; set; }
        public virtual DbSet<T_CA_MANAGER_RIGHTS> T_CA_MANAGER_RIGHTS { get; set; }
        public virtual DbSet<T_DCOM_DACL> T_DCOM_DACL { get; set; }
        public virtual DbSet<T_DIAGNOSTICS> T_DIAGNOSTICS { get; set; }
        public virtual DbSet<T_EMPTY_GROUPS> T_EMPTY_GROUPS { get; set; }
        public virtual DbSet<T_EVENT_4663_LOG> T_EVENT_4663_LOG { get; set; }
        public virtual DbSet<T_EXCHANGE_DACL> T_EXCHANGE_DACL { get; set; }
        public virtual DbSet<T_EXCHANGE_MAILBOX> T_EXCHANGE_MAILBOX { get; set; }
        public virtual DbSet<T_FILE_ASSOC> T_FILE_ASSOC { get; set; }
        public virtual DbSet<T_FILES_DACL> T_FILES_DACL { get; set; }
        public virtual DbSet<T_FILES_SACL> T_FILES_SACL { get; set; }
        public virtual DbSet<T_FOLDERS_DACL> T_FOLDERS_DACL { get; set; }
        public virtual DbSet<T_FOLDERS_SACL> T_FOLDERS_SACL { get; set; }
        public virtual DbSet<T_GLB_GROUP_COUNT> T_GLB_GROUP_COUNT { get; set; }
        public virtual DbSet<T_GPO> T_GPO { get; set; }
        public virtual DbSet<T_GPO_PREFS> T_GPO_PREFS { get; set; }
        public virtual DbSet<T_GPO_RESTRICTED_GROUPS> T_GPO_RESTRICTED_GROUPS { get; set; }
        public virtual DbSet<T_KRBTGT_ATTRIBUTES> T_KRBTGT_ATTRIBUTES { get; set; }
        public virtual DbSet<T_LAST_LOGOFF> T_LAST_LOGOFF { get; set; }
        public virtual DbSet<T_LOC_FIREWALL_RULES> T_LOC_FIREWALL_RULES { get; set; }
        public virtual DbSet<T_LOCAL_GROUPS> T_LOCAL_GROUPS { get; set; }
        public virtual DbSet<T_LOCAL_SIDS> T_LOCAL_SIDS { get; set; }
        public virtual DbSet<T_NTFS_DACL> T_NTFS_DACL { get; set; }
        public virtual DbSet<T_NTFS_SACL> T_NTFS_SACL { get; set; }
        public virtual DbSet<T_PRE_WINDOWS_2000> T_PRE_WINDOWS_2000 { get; set; }
        public virtual DbSet<T_PROCESS_INFO> T_PROCESS_INFO { get; set; }
        public virtual DbSet<T_REGISTRY_DACL> T_REGISTRY_DACL { get; set; }
        public virtual DbSet<T_REGISTRY_LAST_LOGOFF> T_REGISTRY_LAST_LOGOFF { get; set; }
        public virtual DbSet<T_REGISTRY_PROFILES> T_REGISTRY_PROFILES { get; set; }
        public virtual DbSet<T_REGISTRY_SACL> T_REGISTRY_SACL { get; set; }
        public virtual DbSet<T_RODC_DATA> T_RODC_DATA { get; set; }
        public virtual DbSet<T_SCAN_FILES> T_SCAN_FILES { get; set; }
        public virtual DbSet<T_SCAN_SESSIONS> T_SCAN_SESSIONS { get; set; }
        public virtual DbSet<T_SCHEMA_DACL> T_SCHEMA_DACL { get; set; }
        public virtual DbSet<T_SERVICE> T_SERVICE { get; set; }
        public virtual DbSet<T_SHARE_CONTENT_DACL> T_SHARE_CONTENT_DACL { get; set; }
        public virtual DbSet<T_SHARE_CONTENT_SACL> T_SHARE_CONTENT_SACL { get; set; }
        public virtual DbSet<T_SHARE_DACL> T_SHARE_DACL { get; set; }
        public virtual DbSet<T_SID_HISTORY> T_SID_HISTORY { get; set; }
        public virtual DbSet<T_SIGNED_DRIVERS> T_SIGNED_DRIVERS { get; set; }
        public virtual DbSet<T_SOFTWARE> T_SOFTWARE { get; set; }
        public virtual DbSet<T_SPN> T_SPN { get; set; }
        public virtual DbSet<T_TASKS_DACL> T_TASKS_DACL { get; set; }
        public virtual DbSet<T_TRUSTS> T_TRUSTS { get; set; }
        public virtual DbSet<T_UNC_FILES_DACL> T_UNC_FILES_DACL { get; set; }
        public virtual DbSet<T_UNC_FILES_SACL> T_UNC_FILES_SACL { get; set; }
        public virtual DbSet<T_UNC_FOLDERS_DACL> T_UNC_FOLDERS_DACL { get; set; }
        public virtual DbSet<T_UNC_FOLDERS_SACL> T_UNC_FOLDERS_SACL { get; set; }
        public virtual DbSet<T_USER_RIGHTS> T_USER_RIGHTS { get; set; }
        public virtual DbSet<T_USER_TOKENS> T_USER_TOKENS { get; set; }
        public virtual DbSet<T_WMI_DACL> T_WMI_DACL { get; set; }
        public virtual DbSet<TASKS_DACL> TASKS_DACL { get; set; }
        public virtual DbSet<Trustee> Trustees { get; set; }
        public virtual DbSet<TrusteesAsComputer> TrusteesAsComputers { get; set; }
        public virtual DbSet<TrusteesAsGroup> TrusteesAsGroups { get; set; }
        public virtual DbSet<TrusteesAsPrincipal> TrusteesAsPrincipals { get; set; }
        public virtual DbSet<TRUST> TRUSTS { get; set; }
        public virtual DbSet<UNC_FILES_DACL> UNC_FILES_DACL { get; set; }
        public virtual DbSet<UNC_FILES_SACL> UNC_FILES_SACL { get; set; }
        public virtual DbSet<UNC_FOLDERS_DACL> UNC_FOLDERS_DACL { get; set; }
        public virtual DbSet<UNC_FOLDERS_SACL> UNC_FOLDERS_SACL { get; set; }
        public virtual DbSet<UNRESOLVED_MEMBERSHIP> UNRESOLVED_MEMBERSHIP { get; set; }
        public virtual DbSet<USER_RIGHTS> USER_RIGHTS { get; set; }
        public virtual DbSet<USER_TOKENS> USER_TOKENS { get; set; }
        public virtual DbSet<WMI_DACL> WMI_DACL { get; set; }
        public virtual DbSet<ADAdminSDHolderReport> ADAdminSDHolderReports { get; set; }
        public virtual DbSet<AdminCountReport> AdminCountReports { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual ObjectResult<AdExpandedGroupsExplorer_Result> AdExpandedGroupsExplorer(Nullable<int> trusteeId, string authority, string samAccountName, string scope)
        {
            var trusteeIdParameter = trusteeId.HasValue ?
                new ObjectParameter("TrusteeId", trusteeId) :
                new ObjectParameter("TrusteeId", typeof(int));
    
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var samAccountNameParameter = samAccountName != null ?
                new ObjectParameter("SamAccountName", samAccountName) :
                new ObjectParameter("SamAccountName", typeof(string));
    
            var scopeParameter = scope != null ?
                new ObjectParameter("Scope", scope) :
                new ObjectParameter("Scope", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AdExpandedGroupsExplorer_Result>("AdExpandedGroupsExplorer", trusteeIdParameter, authorityParameter, samAccountNameParameter, scopeParameter);
        }
    
        public virtual ObjectResult<AdExpandedGroupsExplorerXRay_Result> AdExpandedGroupsExplorerXRay(Nullable<int> trusteeId, string authority, string samAccountName, string scope)
        {
            var trusteeIdParameter = trusteeId.HasValue ?
                new ObjectParameter("TrusteeId", trusteeId) :
                new ObjectParameter("TrusteeId", typeof(int));
    
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var samAccountNameParameter = samAccountName != null ?
                new ObjectParameter("SamAccountName", samAccountName) :
                new ObjectParameter("SamAccountName", typeof(string));
    
            var scopeParameter = scope != null ?
                new ObjectParameter("Scope", scope) :
                new ObjectParameter("Scope", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AdExpandedGroupsExplorerXRay_Result>("AdExpandedGroupsExplorerXRay", trusteeIdParameter, authorityParameter, samAccountNameParameter, scopeParameter);
        }
    
        public virtual ObjectResult<AdExpandedPrincipalsExplorer_Result> AdExpandedPrincipalsExplorer(Nullable<int> groupId, string authority, string samAccountName, string firstName, string lastName, string objectClass, Nullable<bool> enabled)
        {
            var groupIdParameter = groupId.HasValue ?
                new ObjectParameter("GroupId", groupId) :
                new ObjectParameter("GroupId", typeof(int));
    
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var samAccountNameParameter = samAccountName != null ?
                new ObjectParameter("SamAccountName", samAccountName) :
                new ObjectParameter("SamAccountName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var objectClassParameter = objectClass != null ?
                new ObjectParameter("ObjectClass", objectClass) :
                new ObjectParameter("ObjectClass", typeof(string));
    
            var enabledParameter = enabled.HasValue ?
                new ObjectParameter("Enabled", enabled) :
                new ObjectParameter("Enabled", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AdExpandedPrincipalsExplorer_Result>("AdExpandedPrincipalsExplorer", groupIdParameter, authorityParameter, samAccountNameParameter, firstNameParameter, lastNameParameter, objectClassParameter, enabledParameter);
        }
    
        public virtual int AdTrusteesExplorer(string authority, string samAccountName, string firstName, string lastName, string objectClass, Nullable<bool> enabled)
        {
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var samAccountNameParameter = samAccountName != null ?
                new ObjectParameter("SamAccountName", samAccountName) :
                new ObjectParameter("SamAccountName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var objectClassParameter = objectClass != null ?
                new ObjectParameter("ObjectClass", objectClass) :
                new ObjectParameter("ObjectClass", typeof(string));
    
            var enabledParameter = enabled.HasValue ?
                new ObjectParameter("Enabled", enabled) :
                new ObjectParameter("Enabled", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AdTrusteesExplorer", authorityParameter, samAccountNameParameter, firstNameParameter, lastNameParameter, objectClassParameter, enabledParameter);
        }
    
        public virtual int sp_ClearADTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ClearADTables");
        }
    
        public virtual int sp_ClearAllClientTables(Nullable<System.DateTime> cutoffDate, Nullable<int> batchSize, Nullable<int> serverId)
        {
            var cutoffDateParameter = cutoffDate.HasValue ?
                new ObjectParameter("cutoffDate", cutoffDate) :
                new ObjectParameter("cutoffDate", typeof(System.DateTime));
    
            var batchSizeParameter = batchSize.HasValue ?
                new ObjectParameter("batchSize", batchSize) :
                new ObjectParameter("batchSize", typeof(int));
    
            var serverIdParameter = serverId.HasValue ?
                new ObjectParameter("ServerId", serverId) :
                new ObjectParameter("ServerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ClearAllClientTables", cutoffDateParameter, batchSizeParameter, serverIdParameter);
        }
    
        public virtual int sp_ClearClientTable(string tableName, Nullable<System.DateTime> cutoffDate, Nullable<int> batchSize, Nullable<int> serverId)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("tableName", tableName) :
                new ObjectParameter("tableName", typeof(string));
    
            var cutoffDateParameter = cutoffDate.HasValue ?
                new ObjectParameter("cutoffDate", cutoffDate) :
                new ObjectParameter("cutoffDate", typeof(System.DateTime));
    
            var batchSizeParameter = batchSize.HasValue ?
                new ObjectParameter("batchSize", batchSize) :
                new ObjectParameter("batchSize", typeof(int));
    
            var serverIdParameter = serverId.HasValue ?
                new ObjectParameter("ServerId", serverId) :
                new ObjectParameter("ServerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ClearClientTable", tableNameParameter, cutoffDateParameter, batchSizeParameter, serverIdParameter);
        }
    
        public virtual int sp_ClearSQLTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ClearSQLTables");
        }
    
        public virtual int sp_GetOrphanedSids()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetOrphanedSids");
        }
    
        public virtual int sp_GetSidForServer(string serverFqdn, string serverSID, Nullable<int> option)
        {
            var serverFqdnParameter = serverFqdn != null ?
                new ObjectParameter("ServerFqdn", serverFqdn) :
                new ObjectParameter("ServerFqdn", typeof(string));
    
            var serverSIDParameter = serverSID != null ?
                new ObjectParameter("ServerSID", serverSID) :
                new ObjectParameter("ServerSID", typeof(string));
    
            var optionParameter = option.HasValue ?
                new ObjectParameter("Option", option) :
                new ObjectParameter("Option", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetSidForServer", serverFqdnParameter, serverSIDParameter, optionParameter);
        }
    
        public virtual int sp_GetSidForTrustee(string authority, string samAccountName, Nullable<short> option)
        {
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var samAccountNameParameter = samAccountName != null ?
                new ObjectParameter("SamAccountName", samAccountName) :
                new ObjectParameter("SamAccountName", typeof(string));
    
            var optionParameter = option.HasValue ?
                new ObjectParameter("Option", option) :
                new ObjectParameter("Option", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetSidForTrustee", authorityParameter, samAccountNameParameter, optionParameter);
        }
    
        public virtual int sp_ResolveAD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ResolveAD");
        }
    
        public virtual int sp_ResolveLocalGroups()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ResolveLocalGroups");
        }
    
        public virtual int sp_WriteADDiagnosticInfo(Nullable<System.Guid> oPID, string oPNAME, string oPSTEP, ObjectParameter oPIDOUT)
        {
            var oPIDParameter = oPID.HasValue ?
                new ObjectParameter("OPID", oPID) :
                new ObjectParameter("OPID", typeof(System.Guid));
    
            var oPNAMEParameter = oPNAME != null ?
                new ObjectParameter("OPNAME", oPNAME) :
                new ObjectParameter("OPNAME", typeof(string));
    
            var oPSTEPParameter = oPSTEP != null ?
                new ObjectParameter("OPSTEP", oPSTEP) :
                new ObjectParameter("OPSTEP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_WriteADDiagnosticInfo", oPIDParameter, oPNAMEParameter, oPSTEPParameter, oPIDOUT);
        }
    
        public virtual int sp_WriteDiagnostics(Nullable<System.Guid> opId, string opName, string opStep, Nullable<int> n1, Nullable<int> n2, Nullable<int> n3, Nullable<int> n4, Nullable<int> n5, Nullable<int> n6, Nullable<int> n7, Nullable<int> n8, Nullable<int> n9, Nullable<int> n10, string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, Nullable<System.DateTime> cUTOFFDATE, ObjectParameter oPIDOUT)
        {
            var opIdParameter = opId.HasValue ?
                new ObjectParameter("OpId", opId) :
                new ObjectParameter("OpId", typeof(System.Guid));
    
            var opNameParameter = opName != null ?
                new ObjectParameter("OpName", opName) :
                new ObjectParameter("OpName", typeof(string));
    
            var opStepParameter = opStep != null ?
                new ObjectParameter("OpStep", opStep) :
                new ObjectParameter("OpStep", typeof(string));
    
            var n1Parameter = n1.HasValue ?
                new ObjectParameter("N1", n1) :
                new ObjectParameter("N1", typeof(int));
    
            var n2Parameter = n2.HasValue ?
                new ObjectParameter("N2", n2) :
                new ObjectParameter("N2", typeof(int));
    
            var n3Parameter = n3.HasValue ?
                new ObjectParameter("N3", n3) :
                new ObjectParameter("N3", typeof(int));
    
            var n4Parameter = n4.HasValue ?
                new ObjectParameter("N4", n4) :
                new ObjectParameter("N4", typeof(int));
    
            var n5Parameter = n5.HasValue ?
                new ObjectParameter("N5", n5) :
                new ObjectParameter("N5", typeof(int));
    
            var n6Parameter = n6.HasValue ?
                new ObjectParameter("N6", n6) :
                new ObjectParameter("N6", typeof(int));
    
            var n7Parameter = n7.HasValue ?
                new ObjectParameter("N7", n7) :
                new ObjectParameter("N7", typeof(int));
    
            var n8Parameter = n8.HasValue ?
                new ObjectParameter("N8", n8) :
                new ObjectParameter("N8", typeof(int));
    
            var n9Parameter = n9.HasValue ?
                new ObjectParameter("N9", n9) :
                new ObjectParameter("N9", typeof(int));
    
            var n10Parameter = n10.HasValue ?
                new ObjectParameter("N10", n10) :
                new ObjectParameter("N10", typeof(int));
    
            var s1Parameter = s1 != null ?
                new ObjectParameter("S1", s1) :
                new ObjectParameter("S1", typeof(string));
    
            var s2Parameter = s2 != null ?
                new ObjectParameter("S2", s2) :
                new ObjectParameter("S2", typeof(string));
    
            var s3Parameter = s3 != null ?
                new ObjectParameter("S3", s3) :
                new ObjectParameter("S3", typeof(string));
    
            var s4Parameter = s4 != null ?
                new ObjectParameter("S4", s4) :
                new ObjectParameter("S4", typeof(string));
    
            var s5Parameter = s5 != null ?
                new ObjectParameter("S5", s5) :
                new ObjectParameter("S5", typeof(string));
    
            var s6Parameter = s6 != null ?
                new ObjectParameter("S6", s6) :
                new ObjectParameter("S6", typeof(string));
    
            var s7Parameter = s7 != null ?
                new ObjectParameter("S7", s7) :
                new ObjectParameter("S7", typeof(string));
    
            var s8Parameter = s8 != null ?
                new ObjectParameter("S8", s8) :
                new ObjectParameter("S8", typeof(string));
    
            var s9Parameter = s9 != null ?
                new ObjectParameter("S9", s9) :
                new ObjectParameter("S9", typeof(string));
    
            var s10Parameter = s10 != null ?
                new ObjectParameter("S10", s10) :
                new ObjectParameter("S10", typeof(string));
    
            var cUTOFFDATEParameter = cUTOFFDATE.HasValue ?
                new ObjectParameter("CUTOFFDATE", cUTOFFDATE) :
                new ObjectParameter("CUTOFFDATE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_WriteDiagnostics", opIdParameter, opNameParameter, opStepParameter, n1Parameter, n2Parameter, n3Parameter, n4Parameter, n5Parameter, n6Parameter, n7Parameter, n8Parameter, n9Parameter, n10Parameter, s1Parameter, s2Parameter, s3Parameter, s4Parameter, s5Parameter, s6Parameter, s7Parameter, s8Parameter, s9Parameter, s10Parameter, cUTOFFDATEParameter, oPIDOUT);
        }
    
        public virtual ObjectResult<SPGetSitePermissions_Result> SPGetSitePermissions(Nullable<System.Guid> scopeID, string url, string name)
        {
            var scopeIDParameter = scopeID.HasValue ?
                new ObjectParameter("scopeID", scopeID) :
                new ObjectParameter("scopeID", typeof(System.Guid));
    
            var urlParameter = url != null ?
                new ObjectParameter("Url", url) :
                new ObjectParameter("Url", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPGetSitePermissions_Result>("SPGetSitePermissions", scopeIDParameter, urlParameter, nameParameter);
        }
    
        public virtual ObjectResult<SPGetUserPermissions_Result> SPGetUserPermissions(string user, Nullable<System.Guid> scopeID)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var scopeIDParameter = scopeID.HasValue ?
                new ObjectParameter("scopeID", scopeID) :
                new ObjectParameter("scopeID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPGetUserPermissions_Result>("SPGetUserPermissions", userParameter, scopeIDParameter);
        }
    
        public virtual ObjectResult<SqlDbPermissionsByUserReport_Result> SqlDbPermissionsByUserReport(Nullable<int> adUserId, string authority, string nameSearch, string samSearch)
        {
            var adUserIdParameter = adUserId.HasValue ?
                new ObjectParameter("AdUserId", adUserId) :
                new ObjectParameter("AdUserId", typeof(int));
    
            var authorityParameter = authority != null ?
                new ObjectParameter("Authority", authority) :
                new ObjectParameter("Authority", typeof(string));
    
            var nameSearchParameter = nameSearch != null ?
                new ObjectParameter("NameSearch", nameSearch) :
                new ObjectParameter("NameSearch", typeof(string));
    
            var samSearchParameter = samSearch != null ?
                new ObjectParameter("SamSearch", samSearch) :
                new ObjectParameter("SamSearch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SqlDbPermissionsByUserReport_Result>("SqlDbPermissionsByUserReport", adUserIdParameter, authorityParameter, nameSearchParameter, samSearchParameter);
        }
    
        public virtual ObjectResult<SqlDbPermissionsReport_Result> SqlDbPermissionsReport(Nullable<int> sqlInstanceId, Nullable<int> sqlDbId, string dbNameSearch)
        {
            var sqlInstanceIdParameter = sqlInstanceId.HasValue ?
                new ObjectParameter("SqlInstanceId", sqlInstanceId) :
                new ObjectParameter("SqlInstanceId", typeof(int));
    
            var sqlDbIdParameter = sqlDbId.HasValue ?
                new ObjectParameter("SqlDbId", sqlDbId) :
                new ObjectParameter("SqlDbId", typeof(int));
    
            var dbNameSearchParameter = dbNameSearch != null ?
                new ObjectParameter("DbNameSearch", dbNameSearch) :
                new ObjectParameter("DbNameSearch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SqlDbPermissionsReport_Result>("SqlDbPermissionsReport", sqlInstanceIdParameter, sqlDbIdParameter, dbNameSearchParameter);
        }
    
        public virtual ObjectResult<SqlDbPermissionsSummaryReport_Result> SqlDbPermissionsSummaryReport(Nullable<int> instanceId)
        {
            var instanceIdParameter = instanceId.HasValue ?
                new ObjectParameter("InstanceId", instanceId) :
                new ObjectParameter("InstanceId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SqlDbPermissionsSummaryReport_Result>("SqlDbPermissionsSummaryReport", instanceIdParameter);
        }
    }
}
