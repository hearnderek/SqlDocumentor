using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;
using System;
using System.Collections.Generic;

namespace TestSqlDocumentor
{
    /// <summary>
    /// Massive Visitor objects are a PITA. Here's one to take care of every need you can imagine.
    /// Yes this was written by hand, but it took maybe 10-15 minutes with multi cursors in VSCode.
    /// </summary>
    public class SqlCodeObjectVisitorRegistry : ISqlCodeObjectVisitor
    {

        public void VisitAllChildren(SqlCodeObject sqlCodeObject)
        {
            foreach(var child in sqlCodeObject.Children)
            {
                child.Accept(this);
            }
        }

        #region action registry
        public List<Action<SqlCodeObject>> SqlCodeObjectActions = new List<Action<SqlCodeObject>>();
        public void RegisterForAll(Action<SqlCodeObject> action) { SqlCodeObjectActions.Add(action); }



        public List<Action<SqlAlterFunctionStatement>> SqlAlterFunctionStatementActions = new List<Action<SqlAlterFunctionStatement>>();
        public void Register(Action<SqlAlterFunctionStatement> action)
        {
            this.SqlAlterFunctionStatementActions.Add(action);
        }

        public List<Action<SqlAlterLoginStatement>> SqlAlterLoginStatementActions = new List<Action<SqlAlterLoginStatement>>();
        public void Register(Action<SqlAlterLoginStatement> action)
        {
            this.SqlAlterLoginStatementActions.Add(action);
        }

        public List<Action<SqlAlterProcedureStatement>> SqlAlterProcedureStatementActions = new List<Action<SqlAlterProcedureStatement>>();
        public void Register(Action<SqlAlterProcedureStatement> action)
        {
            this.SqlAlterProcedureStatementActions.Add(action);
        }

        public List<Action<SqlAlterTriggerStatement>> SqlAlterTriggerStatementActions = new List<Action<SqlAlterTriggerStatement>>();
        public void Register(Action<SqlAlterTriggerStatement> action)
        {
            this.SqlAlterTriggerStatementActions.Add(action);
        }

        public List<Action<SqlAlterViewStatement>> SqlAlterViewStatementActions = new List<Action<SqlAlterViewStatement>>();
        public void Register(Action<SqlAlterViewStatement> action)
        {
            this.SqlAlterViewStatementActions.Add(action);
        }

        public List<Action<SqlBackupCertificateStatement>> SqlBackupCertificateStatementActions = new List<Action<SqlBackupCertificateStatement>>();
        public void Register(Action<SqlBackupCertificateStatement> action)
        {
            this.SqlBackupCertificateStatementActions.Add(action);
        }

        public List<Action<SqlBackupDatabaseStatement>> SqlBackupDatabaseStatementActions = new List<Action<SqlBackupDatabaseStatement>>();
        public void Register(Action<SqlBackupDatabaseStatement> action)
        {
            this.SqlBackupDatabaseStatementActions.Add(action);
        }

        public List<Action<SqlBackupLogStatement>> SqlBackupLogStatementActions = new List<Action<SqlBackupLogStatement>>();
        public void Register(Action<SqlBackupLogStatement> action)
        {
            this.SqlBackupLogStatementActions.Add(action);
        }

        public List<Action<SqlBackupMasterKeyStatement>> SqlBackupMasterKeyStatementActions = new List<Action<SqlBackupMasterKeyStatement>>();
        public void Register(Action<SqlBackupMasterKeyStatement> action)
        {
            this.SqlBackupMasterKeyStatementActions.Add(action);
        }

        public List<Action<SqlBackupServiceMasterKeyStatement>> SqlBackupServiceMasterKeyStatementActions = new List<Action<SqlBackupServiceMasterKeyStatement>>();
        public void Register(Action<SqlBackupServiceMasterKeyStatement> action)
        {
            this.SqlBackupServiceMasterKeyStatementActions.Add(action);
        }

        public List<Action<SqlBackupTableStatement>> SqlBackupTableStatementActions = new List<Action<SqlBackupTableStatement>>();
        public void Register(Action<SqlBackupTableStatement> action)
        {
            this.SqlBackupTableStatementActions.Add(action);
        }

        public List<Action<SqlBreakStatement>> SqlBreakStatementActions = new List<Action<SqlBreakStatement>>();
        public void Register(Action<SqlBreakStatement> action)
        {
            this.SqlBreakStatementActions.Add(action);
        }

        public List<Action<SqlCommentStatement>> SqlCommentStatementActions = new List<Action<SqlCommentStatement>>();
        public void Register(Action<SqlCommentStatement> action)
        {
            this.SqlCommentStatementActions.Add(action);
        }

        public List<Action<SqlCompoundStatement>> SqlCompoundStatementActions = new List<Action<SqlCompoundStatement>>();
        public void Register(Action<SqlCompoundStatement> action)
        {
            this.SqlCompoundStatementActions.Add(action);
        }

        public List<Action<SqlContinueStatement>> SqlContinueStatementActions = new List<Action<SqlContinueStatement>>();
        public void Register(Action<SqlContinueStatement> action)
        {
            this.SqlContinueStatementActions.Add(action);
        }

        public List<Action<SqlCreateFunctionStatement>> SqlCreateFunctionStatementActions = new List<Action<SqlCreateFunctionStatement>>();
        public void Register(Action<SqlCreateFunctionStatement> action)
        {
            this.SqlCreateFunctionStatementActions.Add(action);
        }

        public List<Action<SqlCreateIndexStatement>> SqlCreateIndexStatementActions = new List<Action<SqlCreateIndexStatement>>();
        public void Register(Action<SqlCreateIndexStatement> action)
        {
            this.SqlCreateIndexStatementActions.Add(action);
        }

        public List<Action<SqlCreateLoginFromAsymKeyStatement>> SqlCreateLoginFromAsymKeyStatementActions = new List<Action<SqlCreateLoginFromAsymKeyStatement>>();
        public void Register(Action<SqlCreateLoginFromAsymKeyStatement> action)
        {
            this.SqlCreateLoginFromAsymKeyStatementActions.Add(action);
        }

        public List<Action<SqlCreateLoginFromCertificateStatement>> SqlCreateLoginFromCertificateStatementActions = new List<Action<SqlCreateLoginFromCertificateStatement>>();
        public void Register(Action<SqlCreateLoginFromCertificateStatement> action)
        {
            this.SqlCreateLoginFromCertificateStatementActions.Add(action);
        }

        public List<Action<SqlCreateLoginFromWindowsStatement>> SqlCreateLoginFromWindowsStatementActions = new List<Action<SqlCreateLoginFromWindowsStatement>>();
        public void Register(Action<SqlCreateLoginFromWindowsStatement> action)
        {
            this.SqlCreateLoginFromWindowsStatementActions.Add(action);
        }

        public List<Action<SqlCreateLoginWithPasswordStatement>> SqlCreateLoginWithPasswordStatementActions = new List<Action<SqlCreateLoginWithPasswordStatement>>();
        public void Register(Action<SqlCreateLoginWithPasswordStatement> action)
        {
            this.SqlCreateLoginWithPasswordStatementActions.Add(action);
        }

        public List<Action<SqlCreateProcedureStatement>> SqlCreateProcedureStatementActions = new List<Action<SqlCreateProcedureStatement>>();
        public void Register(Action<SqlCreateProcedureStatement> action)
        {
            this.SqlCreateProcedureStatementActions.Add(action);
        }

        public List<Action<SqlCreateRoleStatement>> SqlCreateRoleStatementActions = new List<Action<SqlCreateRoleStatement>>();
        public void Register(Action<SqlCreateRoleStatement> action)
        {
            this.SqlCreateRoleStatementActions.Add(action);
        }

        public List<Action<SqlCreateSchemaStatement>> SqlCreateSchemaStatementActions = new List<Action<SqlCreateSchemaStatement>>();
        public void Register(Action<SqlCreateSchemaStatement> action)
        {
            this.SqlCreateSchemaStatementActions.Add(action);
        }

        public List<Action<SqlCreateSynonymStatement>> SqlCreateSynonymStatementActions = new List<Action<SqlCreateSynonymStatement>>();
        public void Register(Action<SqlCreateSynonymStatement> action)
        {
            this.SqlCreateSynonymStatementActions.Add(action);
        }

        public List<Action<SqlCreateTableStatement>> SqlCreateTableStatementActions = new List<Action<SqlCreateTableStatement>>();
        public void Register(Action<SqlCreateTableStatement> action)
        {
            this.SqlCreateTableStatementActions.Add(action);
        }

        public List<Action<SqlCreateTriggerStatement>> SqlCreateTriggerStatementActions = new List<Action<SqlCreateTriggerStatement>>();
        public void Register(Action<SqlCreateTriggerStatement> action)
        {
            this.SqlCreateTriggerStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserDefinedDataTypeStatement>> SqlCreateUserDefinedDataTypeStatementActions = new List<Action<SqlCreateUserDefinedDataTypeStatement>>();
        public void Register(Action<SqlCreateUserDefinedDataTypeStatement> action)
        {
            this.SqlCreateUserDefinedDataTypeStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserDefinedTableTypeStatement>> SqlCreateUserDefinedTableTypeStatementActions = new List<Action<SqlCreateUserDefinedTableTypeStatement>>();
        public void Register(Action<SqlCreateUserDefinedTableTypeStatement> action)
        {
            this.SqlCreateUserDefinedTableTypeStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserDefinedTypeStatement>> SqlCreateUserDefinedTypeStatementActions = new List<Action<SqlCreateUserDefinedTypeStatement>>();
        public void Register(Action<SqlCreateUserDefinedTypeStatement> action)
        {
            this.SqlCreateUserDefinedTypeStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserFromAsymKeyStatement>> SqlCreateUserFromAsymKeyStatementActions = new List<Action<SqlCreateUserFromAsymKeyStatement>>();
        public void Register(Action<SqlCreateUserFromAsymKeyStatement> action)
        {
            this.SqlCreateUserFromAsymKeyStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserFromCertificateStatement>> SqlCreateUserFromCertificateStatementActions = new List<Action<SqlCreateUserFromCertificateStatement>>();
        public void Register(Action<SqlCreateUserFromCertificateStatement> action)
        {
            this.SqlCreateUserFromCertificateStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserWithImplicitAuthenticationStatement>> SqlCreateUserWithImplicitAuthenticationStatementActions = new List<Action<SqlCreateUserWithImplicitAuthenticationStatement>>();
        public void Register(Action<SqlCreateUserWithImplicitAuthenticationStatement> action)
        {
            this.SqlCreateUserWithImplicitAuthenticationStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserFromLoginStatement>> SqlCreateUserFromLoginStatementActions = new List<Action<SqlCreateUserFromLoginStatement>>();
        public void Register(Action<SqlCreateUserFromLoginStatement> action)
        {
            this.SqlCreateUserFromLoginStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserFromExternalProviderStatement>> SqlCreateUserFromExternalProviderStatementActions = new List<Action<SqlCreateUserFromExternalProviderStatement>>();
        public void Register(Action<SqlCreateUserFromExternalProviderStatement> action)
        {
            this.SqlCreateUserFromExternalProviderStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserStatement>> SqlCreateUserStatementActions = new List<Action<SqlCreateUserStatement>>();
        public void Register(Action<SqlCreateUserStatement> action)
        {
            this.SqlCreateUserStatementActions.Add(action);
        }

        public List<Action<SqlCreateUserWithoutLoginStatement>> SqlCreateUserWithoutLoginStatementActions = new List<Action<SqlCreateUserWithoutLoginStatement>>();
        public void Register(Action<SqlCreateUserWithoutLoginStatement> action)
        {
            this.SqlCreateUserWithoutLoginStatementActions.Add(action);
        }

        public List<Action<SqlCreateViewStatement>> SqlCreateViewStatementActions = new List<Action<SqlCreateViewStatement>>();
        public void Register(Action<SqlCreateViewStatement> action)
        {
            this.SqlCreateViewStatementActions.Add(action);
        }

        public List<Action<SqlCursorDeclareStatement>> SqlCursorDeclareStatementActions = new List<Action<SqlCursorDeclareStatement>>();
        public void Register(Action<SqlCursorDeclareStatement> action)
        {
            this.SqlCursorDeclareStatementActions.Add(action);
        }

        public List<Action<SqlDBCCStatement>> SqlDBCCStatementActions = new List<Action<SqlDBCCStatement>>();
        public void Register(Action<SqlDBCCStatement> action)
        {
            this.SqlDBCCStatementActions.Add(action);
        }

        public List<Action<SqlDeleteStatement>> SqlDeleteStatementActions = new List<Action<SqlDeleteStatement>>();
        public void Register(Action<SqlDeleteStatement> action)
        {
            this.SqlDeleteStatementActions.Add(action);
        }

        public List<Action<SqlDenyStatement>> SqlDenyStatementActions = new List<Action<SqlDenyStatement>>();
        public void Register(Action<SqlDenyStatement> action)
        {
            this.SqlDenyStatementActions.Add(action);
        }

        public List<Action<SqlDropAggregateStatement>> SqlDropAggregateStatementActions = new List<Action<SqlDropAggregateStatement>>();
        public void Register(Action<SqlDropAggregateStatement> action)
        {
            this.SqlDropAggregateStatementActions.Add(action);
        }

        public List<Action<SqlDropDatabaseStatement>> SqlDropDatabaseStatementActions = new List<Action<SqlDropDatabaseStatement>>();
        public void Register(Action<SqlDropDatabaseStatement> action)
        {
            this.SqlDropDatabaseStatementActions.Add(action);
        }

        public List<Action<SqlDropDefaultStatement>> SqlDropDefaultStatementActions = new List<Action<SqlDropDefaultStatement>>();
        public void Register(Action<SqlDropDefaultStatement> action)
        {
            this.SqlDropDefaultStatementActions.Add(action);
        }

        public List<Action<SqlDropFunctionStatement>> SqlDropFunctionStatementActions = new List<Action<SqlDropFunctionStatement>>();
        public void Register(Action<SqlDropFunctionStatement> action)
        {
            this.SqlDropFunctionStatementActions.Add(action);
        }

        public List<Action<SqlDropLoginStatement>> SqlDropLoginStatementActions = new List<Action<SqlDropLoginStatement>>();
        public void Register(Action<SqlDropLoginStatement> action)
        {
            this.SqlDropLoginStatementActions.Add(action);
        }

        public List<Action<SqlDropProcedureStatement>> SqlDropProcedureStatementActions = new List<Action<SqlDropProcedureStatement>>();
        public void Register(Action<SqlDropProcedureStatement> action)
        {
            this.SqlDropProcedureStatementActions.Add(action);
        }

        public List<Action<SqlDropRuleStatement>> SqlDropRuleStatementActions = new List<Action<SqlDropRuleStatement>>();
        public void Register(Action<SqlDropRuleStatement> action)
        {
            this.SqlDropRuleStatementActions.Add(action);
        }

        public List<Action<SqlDropSchemaStatement>> SqlDropSchemaStatementActions = new List<Action<SqlDropSchemaStatement>>();
        public void Register(Action<SqlDropSchemaStatement> action)
        {
            this.SqlDropSchemaStatementActions.Add(action);
        }

        public List<Action<SqlDropSecurityPolicyStatement>> SqlDropSecurityPolicyStatementActions = new List<Action<SqlDropSecurityPolicyStatement>>();
        public void Register(Action<SqlDropSecurityPolicyStatement> action)
        {
            this.SqlDropSecurityPolicyStatementActions.Add(action);
        }

        public List<Action<SqlDropSequenceStatement>> SqlDropSequenceStatementActions = new List<Action<SqlDropSequenceStatement>>();
        public void Register(Action<SqlDropSequenceStatement> action)
        {
            this.SqlDropSequenceStatementActions.Add(action);
        }

        public List<Action<SqlDropSynonymStatement>> SqlDropSynonymStatementActions = new List<Action<SqlDropSynonymStatement>>();
        public void Register(Action<SqlDropSynonymStatement> action)
        {
            this.SqlDropSynonymStatementActions.Add(action);
        }

        public List<Action<SqlDropTableStatement>> SqlDropTableStatementActions = new List<Action<SqlDropTableStatement>>();
        public void Register(Action<SqlDropTableStatement> action)
        {
            this.SqlDropTableStatementActions.Add(action);
        }

        public List<Action<SqlDropTriggerStatement>> SqlDropTriggerStatementActions = new List<Action<SqlDropTriggerStatement>>();
        public void Register(Action<SqlDropTriggerStatement> action)
        {
            this.SqlDropTriggerStatementActions.Add(action);
        }

        public List<Action<SqlDropTypeStatement>> SqlDropTypeStatementActions = new List<Action<SqlDropTypeStatement>>();
        public void Register(Action<SqlDropTypeStatement> action)
        {
            this.SqlDropTypeStatementActions.Add(action);
        }

        public List<Action<SqlDropUserStatement>> SqlDropUserStatementActions = new List<Action<SqlDropUserStatement>>();
        public void Register(Action<SqlDropUserStatement> action)
        {
            this.SqlDropUserStatementActions.Add(action);
        }

        public List<Action<SqlDropViewStatement>> SqlDropViewStatementActions = new List<Action<SqlDropViewStatement>>();
        public void Register(Action<SqlDropViewStatement> action)
        {
            this.SqlDropViewStatementActions.Add(action);
        }

        public List<Action<SqlExecuteModuleStatement>> SqlExecuteModuleStatementActions = new List<Action<SqlExecuteModuleStatement>>();
        public void Register(Action<SqlExecuteModuleStatement> action)
        {
            this.SqlExecuteModuleStatementActions.Add(action);
        }

        public List<Action<SqlExecuteStringStatement>> SqlExecuteStringStatementActions = new List<Action<SqlExecuteStringStatement>>();
        public void Register(Action<SqlExecuteStringStatement> action)
        {
            this.SqlExecuteStringStatementActions.Add(action);
        }

        public List<Action<SqlGrantStatement>> SqlGrantStatementActions = new List<Action<SqlGrantStatement>>();
        public void Register(Action<SqlGrantStatement> action)
        {
            this.SqlGrantStatementActions.Add(action);
        }

        public List<Action<SqlIfElseStatement>> SqlIfElseStatementActions = new List<Action<SqlIfElseStatement>>();
        public void Register(Action<SqlIfElseStatement> action)
        {
            this.SqlIfElseStatementActions.Add(action);
        }

        public List<Action<SqlInlineTableVariableDeclareStatement>> SqlInlineTableVariableDeclareStatementActions = new List<Action<SqlInlineTableVariableDeclareStatement>>();
        public void Register(Action<SqlInlineTableVariableDeclareStatement> action)
        {
            this.SqlInlineTableVariableDeclareStatementActions.Add(action);
        }

        public List<Action<SqlInsertStatement>> SqlInsertStatementActions = new List<Action<SqlInsertStatement>>();
        public void Register(Action<SqlInsertStatement> action)
        {
            this.SqlInsertStatementActions.Add(action);
        }

        public List<Action<SqlMergeStatement>> SqlMergeStatementActions = new List<Action<SqlMergeStatement>>();
        public void Register(Action<SqlMergeStatement> action)
        {
            this.SqlMergeStatementActions.Add(action);
        }

        public List<Action<SqlStatement>> SqlStatementActions = new List<Action<SqlStatement>>();
        public void Register(Action<SqlStatement> action)
        {
            this.SqlStatementActions.Add(action);
        }

        public List<Action<SqlRestoreDatabaseStatement>> SqlRestoreDatabaseStatementActions = new List<Action<SqlRestoreDatabaseStatement>>();
        public void Register(Action<SqlRestoreDatabaseStatement> action)
        {
            this.SqlRestoreDatabaseStatementActions.Add(action);
        }

        public List<Action<SqlRestoreInformationStatement>> SqlRestoreInformationStatementActions = new List<Action<SqlRestoreInformationStatement>>();
        public void Register(Action<SqlRestoreInformationStatement> action)
        {
            this.SqlRestoreInformationStatementActions.Add(action);
        }

        public List<Action<SqlRestoreLogStatement>> SqlRestoreLogStatementActions = new List<Action<SqlRestoreLogStatement>>();
        public void Register(Action<SqlRestoreLogStatement> action)
        {
            this.SqlRestoreLogStatementActions.Add(action);
        }

        public List<Action<SqlRestoreMasterKeyStatement>> SqlRestoreMasterKeyStatementActions = new List<Action<SqlRestoreMasterKeyStatement>>();
        public void Register(Action<SqlRestoreMasterKeyStatement> action)
        {
            this.SqlRestoreMasterKeyStatementActions.Add(action);
        }

        public List<Action<SqlRestoreServiceMasterKeyStatement>> SqlRestoreServiceMasterKeyStatementActions = new List<Action<SqlRestoreServiceMasterKeyStatement>>();
        public void Register(Action<SqlRestoreServiceMasterKeyStatement> action)
        {
            this.SqlRestoreServiceMasterKeyStatementActions.Add(action);
        }

        public List<Action<SqlRestoreTableStatement>> SqlRestoreTableStatementActions = new List<Action<SqlRestoreTableStatement>>();
        public void Register(Action<SqlRestoreTableStatement> action)
        {
            this.SqlRestoreTableStatementActions.Add(action);
        }

        public List<Action<SqlReturnStatement>> SqlReturnStatementActions = new List<Action<SqlReturnStatement>>();
        public void Register(Action<SqlReturnStatement> action)
        {
            this.SqlReturnStatementActions.Add(action);
        }

        public List<Action<SqlRevokeStatement>> SqlRevokeStatementActions = new List<Action<SqlRevokeStatement>>();
        public void Register(Action<SqlRevokeStatement> action)
        {
            this.SqlRevokeStatementActions.Add(action);
        }

        public List<Action<SqlSelectStatement>> SqlSelectStatementActions = new List<Action<SqlSelectStatement>>();
        public void Register(Action<SqlSelectStatement> action)
        {
            this.SqlSelectStatementActions.Add(action);
        }

        public List<Action<SqlSetAssignmentStatement>> SqlSetAssignmentStatementActions = new List<Action<SqlSetAssignmentStatement>>();
        public void Register(Action<SqlSetAssignmentStatement> action)
        {
            this.SqlSetAssignmentStatementActions.Add(action);
        }

        public List<Action<SqlSetStatement>> SqlSetStatementActions = new List<Action<SqlSetStatement>>();
        public void Register(Action<SqlSetStatement> action)
        {
            this.SqlSetStatementActions.Add(action);
        }

        public List<Action<SqlTryCatchStatement>> SqlTryCatchStatementActions = new List<Action<SqlTryCatchStatement>>();
        public void Register(Action<SqlTryCatchStatement> action)
        {
            this.SqlTryCatchStatementActions.Add(action);
        }

        public List<Action<SqlUpdateStatement>> SqlUpdateStatementActions = new List<Action<SqlUpdateStatement>>();
        public void Register(Action<SqlUpdateStatement> action)
        {
            this.SqlUpdateStatementActions.Add(action);
        }

        public List<Action<SqlUseStatement>> SqlUseStatementActions = new List<Action<SqlUseStatement>>();
        public void Register(Action<SqlUseStatement> action)
        {
            this.SqlUseStatementActions.Add(action);
        }

        public List<Action<SqlVariableDeclareStatement>> SqlVariableDeclareStatementActions = new List<Action<SqlVariableDeclareStatement>>();
        public void Register(Action<SqlVariableDeclareStatement> action)
        {
            this.SqlVariableDeclareStatementActions.Add(action);
        }

        public List<Action<SqlWhileStatement>> SqlWhileStatementActions = new List<Action<SqlWhileStatement>>();
        public void Register(Action<SqlWhileStatement> action)
        {
            this.SqlWhileStatementActions.Add(action);
        }

        public List<Action<SqlAggregateFunctionCallExpression>> SqlAggregateFunctionCallExpressionActions = new List<Action<SqlAggregateFunctionCallExpression>>();
        public void Register(Action<SqlAggregateFunctionCallExpression> action)
        {
            this.SqlAggregateFunctionCallExpressionActions.Add(action);
        }

        public List<Action<SqlAllAnyComparisonBooleanExpression>> SqlAllAnyComparisonBooleanExpressionActions = new List<Action<SqlAllAnyComparisonBooleanExpression>>();
        public void Register(Action<SqlAllAnyComparisonBooleanExpression> action)
        {
            this.SqlAllAnyComparisonBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlAllowPageLocksIndexOption>> SqlAllowPageLocksIndexOptionActions = new List<Action<SqlAllowPageLocksIndexOption>>();
        public void Register(Action<SqlAllowPageLocksIndexOption> action)
        {
            this.SqlAllowPageLocksIndexOptionActions.Add(action);
        }

        public List<Action<SqlAllowRowLocksIndexOption>> SqlAllowRowLocksIndexOptionActions = new List<Action<SqlAllowRowLocksIndexOption>>();
        public void Register(Action<SqlAllowRowLocksIndexOption> action)
        {
            this.SqlAllowRowLocksIndexOptionActions.Add(action);
        }

        public List<Action<SqlAssignment>> SqlAssignmentActions = new List<Action<SqlAssignment>>();
        public void Register(Action<SqlAssignment> action)
        {
            this.SqlAssignmentActions.Add(action);
        }

        public List<Action<SqlAtTimeZoneExpression>> SqlAtTimeZoneExpressionActions = new List<Action<SqlAtTimeZoneExpression>>();
        public void Register(Action<SqlAtTimeZoneExpression> action)
        {
            this.SqlAtTimeZoneExpressionActions.Add(action);
        }

        public List<Action<SqlBatch>> SqlBatchActions = new List<Action<SqlBatch>>();
        public void Register(Action<SqlBatch> action)
        {
            this.SqlBatchActions.Add(action);
        }

        public List<Action<SqlBetweenBooleanExpression>> SqlBetweenBooleanExpressionActions = new List<Action<SqlBetweenBooleanExpression>>();
        public void Register(Action<SqlBetweenBooleanExpression> action)
        {
            this.SqlBetweenBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlBinaryBooleanExpression>> SqlBinaryBooleanExpressionActions = new List<Action<SqlBinaryBooleanExpression>>();
        public void Register(Action<SqlBinaryBooleanExpression> action)
        {
            this.SqlBinaryBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlBinaryFilterExpression>> SqlBinaryFilterExpressionActions = new List<Action<SqlBinaryFilterExpression>>();
        public void Register(Action<SqlBinaryFilterExpression> action)
        {
            this.SqlBinaryFilterExpressionActions.Add(action);
        }

        public List<Action<SqlBinaryQueryExpression>> SqlBinaryQueryExpressionActions = new List<Action<SqlBinaryQueryExpression>>();
        public void Register(Action<SqlBinaryQueryExpression> action)
        {
            this.SqlBinaryQueryExpressionActions.Add(action);
        }

        public List<Action<SqlBinaryScalarExpression>> SqlBinaryScalarExpressionActions = new List<Action<SqlBinaryScalarExpression>>();
        public void Register(Action<SqlBinaryScalarExpression> action)
        {
            this.SqlBinaryScalarExpressionActions.Add(action);
        }

        public List<Action<SqlBooleanExpression>> SqlBooleanExpressionActions = new List<Action<SqlBooleanExpression>>();
        public void Register(Action<SqlBooleanExpression> action)
        {
            this.SqlBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlBooleanFilterExpression>> SqlBooleanFilterExpressionActions = new List<Action<SqlBooleanFilterExpression>>();
        public void Register(Action<SqlBooleanFilterExpression> action)
        {
            this.SqlBooleanFilterExpressionActions.Add(action);
        }

        public List<Action<SqlBuiltinScalarFunctionCallExpression>> SqlBuiltinScalarFunctionCallExpressionActions = new List<Action<SqlBuiltinScalarFunctionCallExpression>>();
        public void Register(Action<SqlBuiltinScalarFunctionCallExpression> action)
        {
            this.SqlBuiltinScalarFunctionCallExpressionActions.Add(action);
        }

        public List<Action<SqlCastExpression>> SqlCastExpressionActions = new List<Action<SqlCastExpression>>();
        public void Register(Action<SqlCastExpression> action)
        {
            this.SqlCastExpressionActions.Add(action);
        }

        public List<Action<SqlChangeTrackingContext>> SqlChangeTrackingContextActions = new List<Action<SqlChangeTrackingContext>>();
        public void Register(Action<SqlChangeTrackingContext> action)
        {
            this.SqlChangeTrackingContextActions.Add(action);
        }

        public List<Action<SqlCheckConstraint>> SqlCheckConstraintActions = new List<Action<SqlCheckConstraint>>();
        public void Register(Action<SqlCheckConstraint> action)
        {
            this.SqlCheckConstraintActions.Add(action);
        }

        public List<Action<SqlClrAssemblySpecifier>> SqlClrAssemblySpecifierActions = new List<Action<SqlClrAssemblySpecifier>>();
        public void Register(Action<SqlClrAssemblySpecifier> action)
        {
            this.SqlClrAssemblySpecifierActions.Add(action);
        }

        public List<Action<SqlClrClassSpecifier>> SqlClrClassSpecifierActions = new List<Action<SqlClrClassSpecifier>>();
        public void Register(Action<SqlClrClassSpecifier> action)
        {
            this.SqlClrClassSpecifierActions.Add(action);
        }

        public List<Action<SqlClrFunctionBodyDefinition>> SqlClrFunctionBodyDefinitionActions = new List<Action<SqlClrFunctionBodyDefinition>>();
        public void Register(Action<SqlClrFunctionBodyDefinition> action)
        {
            this.SqlClrFunctionBodyDefinitionActions.Add(action);
        }

        public List<Action<SqlClrMethodSpecifier>> SqlClrMethodSpecifierActions = new List<Action<SqlClrMethodSpecifier>>();
        public void Register(Action<SqlClrMethodSpecifier> action)
        {
            this.SqlClrMethodSpecifierActions.Add(action);
        }

        public List<Action<SqlCollateScalarExpression>> SqlCollateScalarExpressionActions = new List<Action<SqlCollateScalarExpression>>();
        public void Register(Action<SqlCollateScalarExpression> action)
        {
            this.SqlCollateScalarExpressionActions.Add(action);
        }

        public List<Action<SqlCollation>> SqlCollationActions = new List<Action<SqlCollation>>();
        public void Register(Action<SqlCollation> action)
        {
            this.SqlCollationActions.Add(action);
        }

        public List<Action<SqlColumnAssignment>> SqlColumnAssignmentActions = new List<Action<SqlColumnAssignment>>();
        public void Register(Action<SqlColumnAssignment> action)
        {
            this.SqlColumnAssignmentActions.Add(action);
        }

        public List<Action<SqlDefaultConstraint>> SqlDefaultConstraintActions = new List<Action<SqlDefaultConstraint>>();
        public void Register(Action<SqlDefaultConstraint> action)
        {
            this.SqlDefaultConstraintActions.Add(action);
        }

        public List<Action<SqlColumnDefinition>> SqlColumnDefinitionActions = new List<Action<SqlColumnDefinition>>();
        public void Register(Action<SqlColumnDefinition> action)
        {
            this.SqlColumnDefinitionActions.Add(action);
        }

        public List<Action<SqlColumnIdentity>> SqlColumnIdentityActions = new List<Action<SqlColumnIdentity>>();
        public void Register(Action<SqlColumnIdentity> action)
        {
            this.SqlColumnIdentityActions.Add(action);
        }

        public List<Action<SqlColumnRefExpression>> SqlColumnRefExpressionActions = new List<Action<SqlColumnRefExpression>>();
        public void Register(Action<SqlColumnRefExpression> action)
        {
            this.SqlColumnRefExpressionActions.Add(action);
        }

        public List<Action<SqlCommonTableExpression>> SqlCommonTableExpressionActions = new List<Action<SqlCommonTableExpression>>();
        public void Register(Action<SqlCommonTableExpression> action)
        {
            this.SqlCommonTableExpressionActions.Add(action);
        }

        public List<Action<SqlComparisonBooleanExpression>> SqlComparisonBooleanExpressionActions = new List<Action<SqlComparisonBooleanExpression>>();
        public void Register(Action<SqlComparisonBooleanExpression> action)
        {
            this.SqlComparisonBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlCompressionPartitionRange>> SqlCompressionPartitionRangeActions = new List<Action<SqlCompressionPartitionRange>>();
        public void Register(Action<SqlCompressionPartitionRange> action)
        {
            this.SqlCompressionPartitionRangeActions.Add(action);
        }

        public List<Action<SqlComputedColumnDefinition>> SqlComputedColumnDefinitionActions = new List<Action<SqlComputedColumnDefinition>>();
        public void Register(Action<SqlComputedColumnDefinition> action)
        {
            this.SqlComputedColumnDefinitionActions.Add(action);
        }

        public List<Action<SqlConditionClause>> SqlConditionClauseActions = new List<Action<SqlConditionClause>>();
        public void Register(Action<SqlConditionClause> action)
        {
            this.SqlConditionClauseActions.Add(action);
        }

        public List<Action<SqlConstraint>> SqlConstraintActions = new List<Action<SqlConstraint>>();
        public void Register(Action<SqlConstraint> action)
        {
            this.SqlConstraintActions.Add(action);
        }

        public List<Action<SqlConvertExpression>> SqlConvertExpressionActions = new List<Action<SqlConvertExpression>>();
        public void Register(Action<SqlConvertExpression> action)
        {
            this.SqlConvertExpressionActions.Add(action);
        }

        public List<Action<SqlCreateUserOption>> SqlCreateUserOptionActions = new List<Action<SqlCreateUserOption>>();
        public void Register(Action<SqlCreateUserOption> action)
        {
            this.SqlCreateUserOptionActions.Add(action);
        }

        public List<Action<SqlCubeGroupByItem>> SqlCubeGroupByItemActions = new List<Action<SqlCubeGroupByItem>>();
        public void Register(Action<SqlCubeGroupByItem> action)
        {
            this.SqlCubeGroupByItemActions.Add(action);
        }

        public List<Action<SqlCursorOption>> SqlCursorOptionActions = new List<Action<SqlCursorOption>>();
        public void Register(Action<SqlCursorOption> action)
        {
            this.SqlCursorOptionActions.Add(action);
        }

        public List<Action<SqlCursorVariableAssignment>> SqlCursorVariableAssignmentActions = new List<Action<SqlCursorVariableAssignment>>();
        public void Register(Action<SqlCursorVariableAssignment> action)
        {
            this.SqlCursorVariableAssignmentActions.Add(action);
        }

        public List<Action<SqlCursorVariableRefExpression>> SqlCursorVariableRefExpressionActions = new List<Action<SqlCursorVariableRefExpression>>();
        public void Register(Action<SqlCursorVariableRefExpression> action)
        {
            this.SqlCursorVariableRefExpressionActions.Add(action);
        }

        public List<Action<SqlDataCompressionIndexOption>> SqlDataCompressionIndexOptionActions = new List<Action<SqlDataCompressionIndexOption>>();
        public void Register(Action<SqlDataCompressionIndexOption> action)
        {
            this.SqlDataCompressionIndexOptionActions.Add(action);
        }

        public List<Action<SqlDataType>> SqlDataTypeActions = new List<Action<SqlDataType>>();
        public void Register(Action<SqlDataType> action)
        {
            this.SqlDataTypeActions.Add(action);
        }

        public List<Action<SqlDataTypeSpecification>> SqlDataTypeSpecificationActions = new List<Action<SqlDataTypeSpecification>>();
        public void Register(Action<SqlDataTypeSpecification> action)
        {
            this.SqlDataTypeSpecificationActions.Add(action);
        }

        public List<Action<SqlDdlTriggerDefinition>> SqlDdlTriggerDefinitionActions = new List<Action<SqlDdlTriggerDefinition>>();
        public void Register(Action<SqlDdlTriggerDefinition> action)
        {
            this.SqlDdlTriggerDefinitionActions.Add(action);
        }

        public List<Action<SqlDefaultValuesInsertMergeActionSource>> SqlDefaultValuesInsertMergeActionSourceActions = new List<Action<SqlDefaultValuesInsertMergeActionSource>>();
        public void Register(Action<SqlDefaultValuesInsertMergeActionSource> action)
        {
            this.SqlDefaultValuesInsertMergeActionSourceActions.Add(action);
        }

        public List<Action<SqlDefaultValuesInsertSource>> SqlDefaultValuesInsertSourceActions = new List<Action<SqlDefaultValuesInsertSource>>();
        public void Register(Action<SqlDefaultValuesInsertSource> action)
        {
            this.SqlDefaultValuesInsertSourceActions.Add(action);
        }

        public List<Action<SqlDeleteMergeAction>> SqlDeleteMergeActionActions = new List<Action<SqlDeleteMergeAction>>();
        public void Register(Action<SqlDeleteMergeAction> action)
        {
            this.SqlDeleteMergeActionActions.Add(action);
        }

        public List<Action<SqlDeleteSpecification>> SqlDeleteSpecificationActions = new List<Action<SqlDeleteSpecification>>();
        public void Register(Action<SqlDeleteSpecification> action)
        {
            this.SqlDeleteSpecificationActions.Add(action);
        }

        public List<Action<SqlDerivedTableExpression>> SqlDerivedTableExpressionActions = new List<Action<SqlDerivedTableExpression>>();
        public void Register(Action<SqlDerivedTableExpression> action)
        {
            this.SqlDerivedTableExpressionActions.Add(action);
        }

        public List<Action<SqlDmlSpecificationTableSource>> SqlDmlSpecificationTableSourceActions = new List<Action<SqlDmlSpecificationTableSource>>();
        public void Register(Action<SqlDmlSpecificationTableSource> action)
        {
            this.SqlDmlSpecificationTableSourceActions.Add(action);
        }

        public List<Action<SqlDmlTriggerDefinition>> SqlDmlTriggerDefinitionActions = new List<Action<SqlDmlTriggerDefinition>>();
        public void Register(Action<SqlDmlTriggerDefinition> action)
        {
            this.SqlDmlTriggerDefinitionActions.Add(action);
        }

        public List<Action<SqlDropExistingIndexOption>> SqlDropExistingIndexOptionActions = new List<Action<SqlDropExistingIndexOption>>();
        public void Register(Action<SqlDropExistingIndexOption> action)
        {
            this.SqlDropExistingIndexOptionActions.Add(action);
        }

        public List<Action<SqlExecuteArgument>> SqlExecuteArgumentActions = new List<Action<SqlExecuteArgument>>();
        public void Register(Action<SqlExecuteArgument> action)
        {
            this.SqlExecuteArgumentActions.Add(action);
        }

        public List<Action<SqlExecuteAsClause>> SqlExecuteAsClauseActions = new List<Action<SqlExecuteAsClause>>();
        public void Register(Action<SqlExecuteAsClause> action)
        {
            this.SqlExecuteAsClauseActions.Add(action);
        }

        public List<Action<SqlExistsBooleanExpression>> SqlExistsBooleanExpressionActions = new List<Action<SqlExistsBooleanExpression>>();
        public void Register(Action<SqlExistsBooleanExpression> action)
        {
            this.SqlExistsBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlFillFactorIndexOption>> SqlFillFactorIndexOptionActions = new List<Action<SqlFillFactorIndexOption>>();
        public void Register(Action<SqlFillFactorIndexOption> action)
        {
            this.SqlFillFactorIndexOptionActions.Add(action);
        }

        public List<Action<SqlFilterClause>> SqlFilterClauseActions = new List<Action<SqlFilterClause>>();
        public void Register(Action<SqlFilterClause> action)
        {
            this.SqlFilterClauseActions.Add(action);
        }

        public List<Action<SqlForBrowseClause>> SqlForBrowseClauseActions = new List<Action<SqlForBrowseClause>>();
        public void Register(Action<SqlForBrowseClause> action)
        {
            this.SqlForBrowseClauseActions.Add(action);
        }

        public List<Action<SqlForeignKeyConstraint>> SqlForeignKeyConstraintActions = new List<Action<SqlForeignKeyConstraint>>();
        public void Register(Action<SqlForeignKeyConstraint> action)
        {
            this.SqlForeignKeyConstraintActions.Add(action);
        }

        public List<Action<SqlForXmlAutoClause>> SqlForXmlAutoClauseActions = new List<Action<SqlForXmlAutoClause>>();
        public void Register(Action<SqlForXmlAutoClause> action)
        {
            this.SqlForXmlAutoClauseActions.Add(action);
        }

        public List<Action<SqlForXmlClause>> SqlForXmlClauseActions = new List<Action<SqlForXmlClause>>();
        public void Register(Action<SqlForXmlClause> action)
        {
            this.SqlForXmlClauseActions.Add(action);
        }

        public List<Action<SqlForXmlDirective>> SqlForXmlDirectiveActions = new List<Action<SqlForXmlDirective>>();
        public void Register(Action<SqlForXmlDirective> action)
        {
            this.SqlForXmlDirectiveActions.Add(action);
        }

        public List<Action<SqlForXmlExplicitClause>> SqlForXmlExplicitClauseActions = new List<Action<SqlForXmlExplicitClause>>();
        public void Register(Action<SqlForXmlExplicitClause> action)
        {
            this.SqlForXmlExplicitClauseActions.Add(action);
        }

        public List<Action<SqlForXmlPathClause>> SqlForXmlPathClauseActions = new List<Action<SqlForXmlPathClause>>();
        public void Register(Action<SqlForXmlPathClause> action)
        {
            this.SqlForXmlPathClauseActions.Add(action);
        }

        public List<Action<SqlForXmlRawClause>> SqlForXmlRawClauseActions = new List<Action<SqlForXmlRawClause>>();
        public void Register(Action<SqlForXmlRawClause> action)
        {
            this.SqlForXmlRawClauseActions.Add(action);
        }

        public List<Action<SqlFromClause>> SqlFromClauseActions = new List<Action<SqlFromClause>>();
        public void Register(Action<SqlFromClause> action)
        {
            this.SqlFromClauseActions.Add(action);
        }

        public List<Action<SqlFullTextBooleanExpression>> SqlFullTextBooleanExpressionActions = new List<Action<SqlFullTextBooleanExpression>>();
        public void Register(Action<SqlFullTextBooleanExpression> action)
        {
            this.SqlFullTextBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlFullTextColumn>> SqlFullTextColumnActions = new List<Action<SqlFullTextColumn>>();
        public void Register(Action<SqlFullTextColumn> action)
        {
            this.SqlFullTextColumnActions.Add(action);
        }

        public List<Action<SqlFunctionDefinition>> SqlFunctionDefinitionActions = new List<Action<SqlFunctionDefinition>>();
        public void Register(Action<SqlFunctionDefinition> action)
        {
            this.SqlFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlGlobalScalarVariableRefExpression>> SqlGlobalScalarVariableRefExpressionActions = new List<Action<SqlGlobalScalarVariableRefExpression>>();
        public void Register(Action<SqlGlobalScalarVariableRefExpression> action)
        {
            this.SqlGlobalScalarVariableRefExpressionActions.Add(action);
        }

        public List<Action<SqlGrandTotalGroupByItem>> SqlGrandTotalGroupByItemActions = new List<Action<SqlGrandTotalGroupByItem>>();
        public void Register(Action<SqlGrandTotalGroupByItem> action)
        {
            this.SqlGrandTotalGroupByItemActions.Add(action);
        }

        public List<Action<SqlGrandTotalGroupingSet>> SqlGrandTotalGroupingSetActions = new List<Action<SqlGrandTotalGroupingSet>>();
        public void Register(Action<SqlGrandTotalGroupingSet> action)
        {
            this.SqlGrandTotalGroupingSetActions.Add(action);
        }

        public List<Action<SqlGroupByClause>> SqlGroupByClauseActions = new List<Action<SqlGroupByClause>>();
        public void Register(Action<SqlGroupByClause> action)
        {
            this.SqlGroupByClauseActions.Add(action);
        }

        public List<Action<SqlGroupBySets>> SqlGroupBySetsActions = new List<Action<SqlGroupBySets>>();
        public void Register(Action<SqlGroupBySets> action)
        {
            this.SqlGroupBySetsActions.Add(action);
        }

        public List<Action<SqlGroupingSetItemsCollection>> SqlGroupingSetItemsCollectionActions = new List<Action<SqlGroupingSetItemsCollection>>();
        public void Register(Action<SqlGroupingSetItemsCollection> action)
        {
            this.SqlGroupingSetItemsCollectionActions.Add(action);
        }

        public List<Action<SqlHavingClause>> SqlHavingClauseActions = new List<Action<SqlHavingClause>>();
        public void Register(Action<SqlHavingClause> action)
        {
            this.SqlHavingClauseActions.Add(action);
        }

        public List<Action<SqlIdentifier>> SqlIdentifierActions = new List<Action<SqlIdentifier>>();
        public void Register(Action<SqlIdentifier> action)
        {
            this.SqlIdentifierActions.Add(action);
        }

        public List<Action<SqlIdentityFunctionCallExpression>> SqlIdentityFunctionCallExpressionActions = new List<Action<SqlIdentityFunctionCallExpression>>();
        public void Register(Action<SqlIdentityFunctionCallExpression> action)
        {
            this.SqlIdentityFunctionCallExpressionActions.Add(action);
        }

        public List<Action<SqlIgnoreDupKeyIndexOption>> SqlIgnoreDupKeyIndexOptionActions = new List<Action<SqlIgnoreDupKeyIndexOption>>();
        public void Register(Action<SqlIgnoreDupKeyIndexOption> action)
        {
            this.SqlIgnoreDupKeyIndexOptionActions.Add(action);
        }

        public List<Action<SqlInBooleanExpression>> SqlInBooleanExpressionActions = new List<Action<SqlInBooleanExpression>>();
        public void Register(Action<SqlInBooleanExpression> action)
        {
            this.SqlInBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlInBooleanExpressionCollectionValue>> SqlInBooleanExpressionCollectionValueActions = new List<Action<SqlInBooleanExpressionCollectionValue>>();
        public void Register(Action<SqlInBooleanExpressionCollectionValue> action)
        {
            this.SqlInBooleanExpressionCollectionValueActions.Add(action);
        }

        public List<Action<SqlInBooleanExpressionQueryValue>> SqlInBooleanExpressionQueryValueActions = new List<Action<SqlInBooleanExpressionQueryValue>>();
        public void Register(Action<SqlInBooleanExpressionQueryValue> action)
        {
            this.SqlInBooleanExpressionQueryValueActions.Add(action);
        }

        public List<Action<SqlIndexedColumn>> SqlIndexedColumnActions = new List<Action<SqlIndexedColumn>>();
        public void Register(Action<SqlIndexedColumn> action)
        {
            this.SqlIndexedColumnActions.Add(action);
        }

        public List<Action<SqlIndexHint>> SqlIndexHintActions = new List<Action<SqlIndexHint>>();
        public void Register(Action<SqlIndexHint> action)
        {
            this.SqlIndexHintActions.Add(action);
        }

        public List<Action<SqlIndexOption>> SqlIndexOptionActions = new List<Action<SqlIndexOption>>();
        public void Register(Action<SqlIndexOption> action)
        {
            this.SqlIndexOptionActions.Add(action);
        }

        public List<Action<SqlInlineIndexConstraint>> SqlInlineIndexConstraintActions = new List<Action<SqlInlineIndexConstraint>>();
        public void Register(Action<SqlInlineIndexConstraint> action)
        {
            this.SqlInlineIndexConstraintActions.Add(action);
        }

        public List<Action<SqlInlineFunctionBodyDefinition>> SqlInlineFunctionBodyDefinitionActions = new List<Action<SqlInlineFunctionBodyDefinition>>();
        public void Register(Action<SqlInlineFunctionBodyDefinition> action)
        {
            this.SqlInlineFunctionBodyDefinitionActions.Add(action);
        }

        public List<Action<SqlInlineTableRelationalFunctionDefinition>> SqlInlineTableRelationalFunctionDefinitionActions = new List<Action<SqlInlineTableRelationalFunctionDefinition>>();
        public void Register(Action<SqlInlineTableRelationalFunctionDefinition> action)
        {
            this.SqlInlineTableRelationalFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlInlineTableVariableDeclaration>> SqlInlineTableVariableDeclarationActions = new List<Action<SqlInlineTableVariableDeclaration>>();
        public void Register(Action<SqlInlineTableVariableDeclaration> action)
        {
            this.SqlInlineTableVariableDeclarationActions.Add(action);
        }

        public List<Action<SqlInsertMergeAction>> SqlInsertMergeActionActions = new List<Action<SqlInsertMergeAction>>();
        public void Register(Action<SqlInsertMergeAction> action)
        {
            this.SqlInsertMergeActionActions.Add(action);
        }

        public List<Action<SqlInsertSpecification>> SqlInsertSpecificationActions = new List<Action<SqlInsertSpecification>>();
        public void Register(Action<SqlInsertSpecification> action)
        {
            this.SqlInsertSpecificationActions.Add(action);
        }

        public List<Action<SqlIntoClause>> SqlIntoClauseActions = new List<Action<SqlIntoClause>>();
        public void Register(Action<SqlIntoClause> action)
        {
            this.SqlIntoClauseActions.Add(action);
        }

        public List<Action<SqlIsNullBooleanExpression>> SqlIsNullBooleanExpressionActions = new List<Action<SqlIsNullBooleanExpression>>();
        public void Register(Action<SqlIsNullBooleanExpression> action)
        {
            this.SqlIsNullBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlLargeDataStorageInformation>> SqlLargeDataStorageInformationActions = new List<Action<SqlLargeDataStorageInformation>>();
        public void Register(Action<SqlLargeDataStorageInformation> action)
        {
            this.SqlLargeDataStorageInformationActions.Add(action);
        }

        public List<Action<SqlLikeBooleanExpression>> SqlLikeBooleanExpressionActions = new List<Action<SqlLikeBooleanExpression>>();
        public void Register(Action<SqlLikeBooleanExpression> action)
        {
            this.SqlLikeBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlLiteralExpression>> SqlLiteralExpressionActions = new List<Action<SqlLiteralExpression>>();
        public void Register(Action<SqlLiteralExpression> action)
        {
            this.SqlLiteralExpressionActions.Add(action);
        }

        public List<Action<SqlLoginPassword>> SqlLoginPasswordActions = new List<Action<SqlLoginPassword>>();
        public void Register(Action<SqlLoginPassword> action)
        {
            this.SqlLoginPasswordActions.Add(action);
        }

        public List<Action<SqlMaxDegreeOfParallelismIndexOption>> SqlMaxDegreeOfParallelismIndexOptionActions = new List<Action<SqlMaxDegreeOfParallelismIndexOption>>();
        public void Register(Action<SqlMaxDegreeOfParallelismIndexOption> action)
        {
            this.SqlMaxDegreeOfParallelismIndexOptionActions.Add(action);
        }

        public List<Action<SqlMergeActionClause>> SqlMergeActionClauseActions = new List<Action<SqlMergeActionClause>>();
        public void Register(Action<SqlMergeActionClause> action)
        {
            this.SqlMergeActionClauseActions.Add(action);
        }

        public List<Action<SqlMergeSpecification>> SqlMergeSpecificationActions = new List<Action<SqlMergeSpecification>>();
        public void Register(Action<SqlMergeSpecification> action)
        {
            this.SqlMergeSpecificationActions.Add(action);
        }

        public List<Action<SqlInsertSource>> SqlInsertSourceActions = new List<Action<SqlInsertSource>>();
        public void Register(Action<SqlInsertSource> action)
        {
            this.SqlInsertSourceActions.Add(action);
        }

        public List<Action<SqlModuleCalledOnNullInputOption>> SqlModuleCalledOnNullInputOptionActions = new List<Action<SqlModuleCalledOnNullInputOption>>();
        public void Register(Action<SqlModuleCalledOnNullInputOption> action)
        {
            this.SqlModuleCalledOnNullInputOptionActions.Add(action);
        }

        public List<Action<SqlModuleEncryptionOption>> SqlModuleEncryptionOptionActions = new List<Action<SqlModuleEncryptionOption>>();
        public void Register(Action<SqlModuleEncryptionOption> action)
        {
            this.SqlModuleEncryptionOptionActions.Add(action);
        }

        public List<Action<SqlModuleExecuteAsOption>> SqlModuleExecuteAsOptionActions = new List<Action<SqlModuleExecuteAsOption>>();
        public void Register(Action<SqlModuleExecuteAsOption> action)
        {
            this.SqlModuleExecuteAsOptionActions.Add(action);
        }

        public List<Action<SqlModuleNativeCompilationOption>> SqlModuleNativeCompilationOptionActions = new List<Action<SqlModuleNativeCompilationOption>>();
        public void Register(Action<SqlModuleNativeCompilationOption> action)
        {
            this.SqlModuleNativeCompilationOptionActions.Add(action);
        }

        public List<Action<SqlModuleOption>> SqlModuleOptionActions = new List<Action<SqlModuleOption>>();
        public void Register(Action<SqlModuleOption> action)
        {
            this.SqlModuleOptionActions.Add(action);
        }

        public List<Action<SqlModuleRecompileOption>> SqlModuleRecompileOptionActions = new List<Action<SqlModuleRecompileOption>>();
        public void Register(Action<SqlModuleRecompileOption> action)
        {
            this.SqlModuleRecompileOptionActions.Add(action);
        }

        public List<Action<SqlModuleReturnsNullOnNullInputOption>> SqlModuleReturnsNullOnNullInputOptionActions = new List<Action<SqlModuleReturnsNullOnNullInputOption>>();
        public void Register(Action<SqlModuleReturnsNullOnNullInputOption> action)
        {
            this.SqlModuleReturnsNullOnNullInputOptionActions.Add(action);
        }

        public List<Action<SqlModuleSchemaBindingOption>> SqlModuleSchemaBindingOptionActions = new List<Action<SqlModuleSchemaBindingOption>>();
        public void Register(Action<SqlModuleSchemaBindingOption> action)
        {
            this.SqlModuleSchemaBindingOptionActions.Add(action);
        }

        public List<Action<SqlModuleViewMetadataOption>> SqlModuleViewMetadataOptionActions = new List<Action<SqlModuleViewMetadataOption>>();
        public void Register(Action<SqlModuleViewMetadataOption> action)
        {
            this.SqlModuleViewMetadataOptionActions.Add(action);
        }

        public List<Action<SqlMultistatementFunctionBodyDefinition>> SqlMultistatementFunctionBodyDefinitionActions = new List<Action<SqlMultistatementFunctionBodyDefinition>>();
        public void Register(Action<SqlMultistatementFunctionBodyDefinition> action)
        {
            this.SqlMultistatementFunctionBodyDefinitionActions.Add(action);
        }

        public List<Action<SqlMultistatementTableRelationalFunctionDefinition>> SqlMultistatementTableRelationalFunctionDefinitionActions = new List<Action<SqlMultistatementTableRelationalFunctionDefinition>>();
        public void Register(Action<SqlMultistatementTableRelationalFunctionDefinition> action)
        {
            this.SqlMultistatementTableRelationalFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlNotBooleanExpression>> SqlNotBooleanExpressionActions = new List<Action<SqlNotBooleanExpression>>();
        public void Register(Action<SqlNotBooleanExpression> action)
        {
            this.SqlNotBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlQueryExpression>> SqlQueryExpressionActions = new List<Action<SqlQueryExpression>>();
        public void Register(Action<SqlQueryExpression> action)
        {
            this.SqlQueryExpressionActions.Add(action);
        }

        public List<Action<SqlScalarExpression>> SqlScalarExpressionActions = new List<Action<SqlScalarExpression>>();
        public void Register(Action<SqlScalarExpression> action)
        {
            this.SqlScalarExpressionActions.Add(action);
        }

        public List<Action<SqlTableExpression>> SqlTableExpressionActions = new List<Action<SqlTableExpression>>();
        public void Register(Action<SqlTableExpression> action)
        {
            this.SqlTableExpressionActions.Add(action);
        }

        public List<Action<SqlObjectIdentifier>> SqlObjectIdentifierActions = new List<Action<SqlObjectIdentifier>>();
        public void Register(Action<SqlObjectIdentifier> action)
        {
            this.SqlObjectIdentifierActions.Add(action);
        }

        public List<Action<SqlObjectReference>> SqlObjectReferenceActions = new List<Action<SqlObjectReference>>();
        public void Register(Action<SqlObjectReference> action)
        {
            this.SqlObjectReferenceActions.Add(action);
        }

        public List<Action<SqlOnlineIndexOption>> SqlOnlineIndexOptionActions = new List<Action<SqlOnlineIndexOption>>();
        public void Register(Action<SqlOnlineIndexOption> action)
        {
            this.SqlOnlineIndexOptionActions.Add(action);
        }

        public List<Action<SqlOptimizeForSequentialKeyIndexOption>> SqlOptimizeForSequentialKeyIndexOptionActions = new List<Action<SqlOptimizeForSequentialKeyIndexOption>>();
        public void Register(Action<SqlOptimizeForSequentialKeyIndexOption> action)
        {
            this.SqlOptimizeForSequentialKeyIndexOptionActions.Add(action);
        }

        public List<Action<SqlResumableIndexOption>> SqlResumableIndexOptionActions = new List<Action<SqlResumableIndexOption>>();
        public void Register(Action<SqlResumableIndexOption> action)
        {
            this.SqlResumableIndexOptionActions.Add(action);
        }

        public List<Action<SqlBucketCountIndexOption>> SqlBucketCountIndexOptionActions = new List<Action<SqlBucketCountIndexOption>>();
        public void Register(Action<SqlBucketCountIndexOption> action)
        {
            this.SqlBucketCountIndexOptionActions.Add(action);
        }

        public List<Action<SqlCompressionDelayIndexOption>> SqlCompressionDelayIndexOptionActions = new List<Action<SqlCompressionDelayIndexOption>>();
        public void Register(Action<SqlCompressionDelayIndexOption> action)
        {
            this.SqlCompressionDelayIndexOptionActions.Add(action);
        }

        public List<Action<SqlMaxDurationIndexOption>> SqlMaxDurationIndexOptionActions = new List<Action<SqlMaxDurationIndexOption>>();
        public void Register(Action<SqlMaxDurationIndexOption> action)
        {
            this.SqlMaxDurationIndexOptionActions.Add(action);
        }

        public List<Action<SqlOffsetFetchClause>> SqlOffsetFetchClauseActions = new List<Action<SqlOffsetFetchClause>>();
        public void Register(Action<SqlOffsetFetchClause> action)
        {
            this.SqlOffsetFetchClauseActions.Add(action);
        }

        public List<Action<SqlOrderByClause>> SqlOrderByClauseActions = new List<Action<SqlOrderByClause>>();
        public void Register(Action<SqlOrderByClause> action)
        {
            this.SqlOrderByClauseActions.Add(action);
        }

        public List<Action<SqlOrderByItem>> SqlOrderByItemActions = new List<Action<SqlOrderByItem>>();
        public void Register(Action<SqlOrderByItem> action)
        {
            this.SqlOrderByItemActions.Add(action);
        }

        public List<Action<SqlOutputClause>> SqlOutputClauseActions = new List<Action<SqlOutputClause>>();
        public void Register(Action<SqlOutputClause> action)
        {
            this.SqlOutputClauseActions.Add(action);
        }

        public List<Action<SqlOutputIntoClause>> SqlOutputIntoClauseActions = new List<Action<SqlOutputIntoClause>>();
        public void Register(Action<SqlOutputIntoClause> action)
        {
            this.SqlOutputIntoClauseActions.Add(action);
        }

        public List<Action<SqlPadIndexOption>> SqlPadIndexOptionActions = new List<Action<SqlPadIndexOption>>();
        public void Register(Action<SqlPadIndexOption> action)
        {
            this.SqlPadIndexOptionActions.Add(action);
        }

        public List<Action<SqlParameterDeclaration>> SqlParameterDeclarationActions = new List<Action<SqlParameterDeclaration>>();
        public void Register(Action<SqlParameterDeclaration> action)
        {
            this.SqlParameterDeclarationActions.Add(action);
        }

        public List<Action<SqlPivotClause>> SqlPivotClauseActions = new List<Action<SqlPivotClause>>();
        public void Register(Action<SqlPivotClause> action)
        {
            this.SqlPivotClauseActions.Add(action);
        }

        public List<Action<SqlPivotTableExpression>> SqlPivotTableExpressionActions = new List<Action<SqlPivotTableExpression>>();
        public void Register(Action<SqlPivotTableExpression> action)
        {
            this.SqlPivotTableExpressionActions.Add(action);
        }

        public List<Action<SqlPrimaryKeyConstraint>> SqlPrimaryKeyConstraintActions = new List<Action<SqlPrimaryKeyConstraint>>();
        public void Register(Action<SqlPrimaryKeyConstraint> action)
        {
            this.SqlPrimaryKeyConstraintActions.Add(action);
        }

        public List<Action<SqlStorageSpecification>> SqlStorageSpecificationActions = new List<Action<SqlStorageSpecification>>();
        public void Register(Action<SqlStorageSpecification> action)
        {
            this.SqlStorageSpecificationActions.Add(action);
        }

        public List<Action<SqlProcedureDefinition>> SqlProcedureDefinitionActions = new List<Action<SqlProcedureDefinition>>();
        public void Register(Action<SqlProcedureDefinition> action)
        {
            this.SqlProcedureDefinitionActions.Add(action);
        }

        public List<Action<SqlQualifiedJoinTableExpression>> SqlQualifiedJoinTableExpressionActions = new List<Action<SqlQualifiedJoinTableExpression>>();
        public void Register(Action<SqlQualifiedJoinTableExpression> action)
        {
            this.SqlQualifiedJoinTableExpressionActions.Add(action);
        }

        public List<Action<SqlQuerySpecification>> SqlQuerySpecificationActions = new List<Action<SqlQuerySpecification>>();
        public void Register(Action<SqlQuerySpecification> action)
        {
            this.SqlQuerySpecificationActions.Add(action);
        }

        public List<Action<SqlQueryWithClause>> SqlQueryWithClauseActions = new List<Action<SqlQueryWithClause>>();
        public void Register(Action<SqlQueryWithClause> action)
        {
            this.SqlQueryWithClauseActions.Add(action);
        }

        public List<Action<SqlRollupGroupByItem>> SqlRollupGroupByItemActions = new List<Action<SqlRollupGroupByItem>>();
        public void Register(Action<SqlRollupGroupByItem> action)
        {
            this.SqlRollupGroupByItemActions.Add(action);
        }

        public List<Action<SqlRowConstructorExpression>> SqlRowConstructorExpressionActions = new List<Action<SqlRowConstructorExpression>>();
        public void Register(Action<SqlRowConstructorExpression> action)
        {
            this.SqlRowConstructorExpressionActions.Add(action);
        }

        public List<Action<SqlScalarClrFunctionDefinition>> SqlScalarClrFunctionDefinitionActions = new List<Action<SqlScalarClrFunctionDefinition>>();
        public void Register(Action<SqlScalarClrFunctionDefinition> action)
        {
            this.SqlScalarClrFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlScalarFunctionReturnType>> SqlScalarFunctionReturnTypeActions = new List<Action<SqlScalarFunctionReturnType>>();
        public void Register(Action<SqlScalarFunctionReturnType> action)
        {
            this.SqlScalarFunctionReturnTypeActions.Add(action);
        }

        public List<Action<SqlScalarRefExpression>> SqlScalarRefExpressionActions = new List<Action<SqlScalarRefExpression>>();
        public void Register(Action<SqlScalarRefExpression> action)
        {
            this.SqlScalarRefExpressionActions.Add(action);
        }

        public List<Action<SqlScalarRelationalFunctionDefinition>> SqlScalarRelationalFunctionDefinitionActions = new List<Action<SqlScalarRelationalFunctionDefinition>>();
        public void Register(Action<SqlScalarRelationalFunctionDefinition> action)
        {
            this.SqlScalarRelationalFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlScalarSubQueryExpression>> SqlScalarSubQueryExpressionActions = new List<Action<SqlScalarSubQueryExpression>>();
        public void Register(Action<SqlScalarSubQueryExpression> action)
        {
            this.SqlScalarSubQueryExpressionActions.Add(action);
        }

        public List<Action<SqlScalarVariableAssignment>> SqlScalarVariableAssignmentActions = new List<Action<SqlScalarVariableAssignment>>();
        public void Register(Action<SqlScalarVariableAssignment> action)
        {
            this.SqlScalarVariableAssignmentActions.Add(action);
        }

        public List<Action<SqlScalarVariableRefExpression>> SqlScalarVariableRefExpressionActions = new List<Action<SqlScalarVariableRefExpression>>();
        public void Register(Action<SqlScalarVariableRefExpression> action)
        {
            this.SqlScalarVariableRefExpressionActions.Add(action);
        }

        public List<Action<SqlScript>> SqlScriptActions = new List<Action<SqlScript>>();
        public void Register(Action<SqlScript> action)
        {
            this.SqlScriptActions.Add(action);
        }

        public List<Action<SqlSearchedCaseExpression>> SqlSearchedCaseExpressionActions = new List<Action<SqlSearchedCaseExpression>>();
        public void Register(Action<SqlSearchedCaseExpression> action)
        {
            this.SqlSearchedCaseExpressionActions.Add(action);
        }

        public List<Action<SqlSearchedWhenClause>> SqlSearchedWhenClauseActions = new List<Action<SqlSearchedWhenClause>>();
        public void Register(Action<SqlSearchedWhenClause> action)
        {
            this.SqlSearchedWhenClauseActions.Add(action);
        }

        public List<Action<SqlSelectClause>> SqlSelectClauseActions = new List<Action<SqlSelectClause>>();
        public void Register(Action<SqlSelectClause> action)
        {
            this.SqlSelectClauseActions.Add(action);
        }

        public List<Action<SqlSelectIntoClause>> SqlSelectIntoClauseActions = new List<Action<SqlSelectIntoClause>>();
        public void Register(Action<SqlSelectIntoClause> action)
        {
            this.SqlSelectIntoClauseActions.Add(action);
        }

        public List<Action<SqlSelectScalarExpression>> SqlSelectScalarExpressionActions = new List<Action<SqlSelectScalarExpression>>();
        public void Register(Action<SqlSelectScalarExpression> action)
        {
            this.SqlSelectScalarExpressionActions.Add(action);
        }

        public List<Action<SqlSelectSpecification>> SqlSelectSpecificationActions = new List<Action<SqlSelectSpecification>>();
        public void Register(Action<SqlSelectSpecification> action)
        {
            this.SqlSelectSpecificationActions.Add(action);
        }

        public List<Action<SqlSelectSpecificationInsertSource>> SqlSelectSpecificationInsertSourceActions = new List<Action<SqlSelectSpecificationInsertSource>>();
        public void Register(Action<SqlSelectSpecificationInsertSource> action)
        {
            this.SqlSelectSpecificationInsertSourceActions.Add(action);
        }

        public List<Action<SqlSelectStarExpression>> SqlSelectStarExpressionActions = new List<Action<SqlSelectStarExpression>>();
        public void Register(Action<SqlSelectStarExpression> action)
        {
            this.SqlSelectStarExpressionActions.Add(action);
        }

        public List<Action<SqlSelectVariableAssignmentExpression>> SqlSelectVariableAssignmentExpressionActions = new List<Action<SqlSelectVariableAssignmentExpression>>();
        public void Register(Action<SqlSelectVariableAssignmentExpression> action)
        {
            this.SqlSelectVariableAssignmentExpressionActions.Add(action);
        }

        public List<Action<SqlSetClause>> SqlSetClauseActions = new List<Action<SqlSetClause>>();
        public void Register(Action<SqlSetClause> action)
        {
            this.SqlSetClauseActions.Add(action);
        }

        public List<Action<SqlSimpleCaseExpression>> SqlSimpleCaseExpressionActions = new List<Action<SqlSimpleCaseExpression>>();
        public void Register(Action<SqlSimpleCaseExpression> action)
        {
            this.SqlSimpleCaseExpressionActions.Add(action);
        }

        public List<Action<SqlSimpleGroupByItem>> SqlSimpleGroupByItemActions = new List<Action<SqlSimpleGroupByItem>>();
        public void Register(Action<SqlSimpleGroupByItem> action)
        {
            this.SqlSimpleGroupByItemActions.Add(action);
        }

        public List<Action<SqlSimpleOrderByClause>> SqlSimpleOrderByClauseActions = new List<Action<SqlSimpleOrderByClause>>();
        public void Register(Action<SqlSimpleOrderByClause> action)
        {
            this.SqlSimpleOrderByClauseActions.Add(action);
        }

        public List<Action<SqlSimpleOrderByItem>> SqlSimpleOrderByItemActions = new List<Action<SqlSimpleOrderByItem>>();
        public void Register(Action<SqlSimpleOrderByItem> action)
        {
            this.SqlSimpleOrderByItemActions.Add(action);
        }

        public List<Action<SqlSimpleWhenClause>> SqlSimpleWhenClauseActions = new List<Action<SqlSimpleWhenClause>>();
        public void Register(Action<SqlSimpleWhenClause> action)
        {
            this.SqlSimpleWhenClauseActions.Add(action);
        }

        public List<Action<SqlSortedDataIndexOption>> SqlSortedDataIndexOptionActions = new List<Action<SqlSortedDataIndexOption>>();
        public void Register(Action<SqlSortedDataIndexOption> action)
        {
            this.SqlSortedDataIndexOptionActions.Add(action);
        }

        public List<Action<SqlSortedDataReorgIndexOption>> SqlSortedDataReorgIndexOptionActions = new List<Action<SqlSortedDataReorgIndexOption>>();
        public void Register(Action<SqlSortedDataReorgIndexOption> action)
        {
            this.SqlSortedDataReorgIndexOptionActions.Add(action);
        }

        public List<Action<SqlSortInTempDbIndexOption>> SqlSortInTempDbIndexOptionActions = new List<Action<SqlSortInTempDbIndexOption>>();
        public void Register(Action<SqlSortInTempDbIndexOption> action)
        {
            this.SqlSortInTempDbIndexOptionActions.Add(action);
        }

        public List<Action<SqlStatisticsIncrementalIndexOption>> SqlStatisticsIncrementalIndexOptionActions = new List<Action<SqlStatisticsIncrementalIndexOption>>();
        public void Register(Action<SqlStatisticsIncrementalIndexOption> action)
        {
            this.SqlStatisticsIncrementalIndexOptionActions.Add(action);
        }

        public List<Action<SqlStatisticsNoRecomputeIndexOption>> SqlStatisticsNoRecomputeIndexOptionActions = new List<Action<SqlStatisticsNoRecomputeIndexOption>>();
        public void Register(Action<SqlStatisticsNoRecomputeIndexOption> action)
        {
            this.SqlStatisticsNoRecomputeIndexOptionActions.Add(action);
        }

        public List<Action<SqlStatisticsOnlyIndexOption>> SqlStatisticsOnlyIndexOptionActions = new List<Action<SqlStatisticsOnlyIndexOption>>();
        public void Register(Action<SqlStatisticsOnlyIndexOption> action)
        {
            this.SqlStatisticsOnlyIndexOptionActions.Add(action);
        }

        public List<Action<SqlTableClrFunctionDefinition>> SqlTableClrFunctionDefinitionActions = new List<Action<SqlTableClrFunctionDefinition>>();
        public void Register(Action<SqlTableClrFunctionDefinition> action)
        {
            this.SqlTableClrFunctionDefinitionActions.Add(action);
        }

        public List<Action<SqlTableConstructorExpression>> SqlTableConstructorExpressionActions = new List<Action<SqlTableConstructorExpression>>();
        public void Register(Action<SqlTableConstructorExpression> action)
        {
            this.SqlTableConstructorExpressionActions.Add(action);
        }

        public List<Action<SqlTableConstructorInsertSource>> SqlTableConstructorInsertSourceActions = new List<Action<SqlTableConstructorInsertSource>>();
        public void Register(Action<SqlTableConstructorInsertSource> action)
        {
            this.SqlTableConstructorInsertSourceActions.Add(action);
        }

        public List<Action<SqlTableDefinition>> SqlTableDefinitionActions = new List<Action<SqlTableDefinition>>();
        public void Register(Action<SqlTableDefinition> action)
        {
            this.SqlTableDefinitionActions.Add(action);
        }

        public List<Action<SqlTableFunctionReturnType>> SqlTableFunctionReturnTypeActions = new List<Action<SqlTableFunctionReturnType>>();
        public void Register(Action<SqlTableFunctionReturnType> action)
        {
            this.SqlTableFunctionReturnTypeActions.Add(action);
        }

        public List<Action<SqlTableHint>> SqlTableHintActions = new List<Action<SqlTableHint>>();
        public void Register(Action<SqlTableHint> action)
        {
            this.SqlTableHintActions.Add(action);
        }

        public List<Action<SqlTableRefExpression>> SqlTableRefExpressionActions = new List<Action<SqlTableRefExpression>>();
        public void Register(Action<SqlTableRefExpression> action)
        {
            this.SqlTableRefExpressionActions.Add(action);
        }

        public List<Action<SqlTableValuedFunctionRefExpression>> SqlTableValuedFunctionRefExpressionActions = new List<Action<SqlTableValuedFunctionRefExpression>>();
        public void Register(Action<SqlTableValuedFunctionRefExpression> action)
        {
            this.SqlTableValuedFunctionRefExpressionActions.Add(action);
        }

        public List<Action<SqlTableVariableRefExpression>> SqlTableVariableRefExpressionActions = new List<Action<SqlTableVariableRefExpression>>();
        public void Register(Action<SqlTableVariableRefExpression> action)
        {
            this.SqlTableVariableRefExpressionActions.Add(action);
        }

        public List<Action<SqlTableUdtInstanceMethodExpression>> SqlTableUdtInstanceMethodExpressionActions = new List<Action<SqlTableUdtInstanceMethodExpression>>();
        public void Register(Action<SqlTableUdtInstanceMethodExpression> action)
        {
            this.SqlTableUdtInstanceMethodExpressionActions.Add(action);
        }

        public List<Action<SqlTargetTableExpression>> SqlTargetTableExpressionActions = new List<Action<SqlTargetTableExpression>>();
        public void Register(Action<SqlTargetTableExpression> action)
        {
            this.SqlTargetTableExpressionActions.Add(action);
        }

        public List<Action<SqlTemporalPeriodDefinition>> SqlTemporalPeriodDefinitionActions = new List<Action<SqlTemporalPeriodDefinition>>();
        public void Register(Action<SqlTemporalPeriodDefinition> action)
        {
            this.SqlTemporalPeriodDefinitionActions.Add(action);
        }

        public List<Action<SqlTopSpecification>> SqlTopSpecificationActions = new List<Action<SqlTopSpecification>>();
        public void Register(Action<SqlTopSpecification> action)
        {
            this.SqlTopSpecificationActions.Add(action);
        }

        public List<Action<SqlTriggerAction>> SqlTriggerActionActions = new List<Action<SqlTriggerAction>>();
        public void Register(Action<SqlTriggerAction> action)
        {
            this.SqlTriggerActionActions.Add(action);
        }

        public List<Action<SqlTriggerDefinition>> SqlTriggerDefinitionActions = new List<Action<SqlTriggerDefinition>>();
        public void Register(Action<SqlTriggerDefinition> action)
        {
            this.SqlTriggerDefinitionActions.Add(action);
        }

        public List<Action<SqlTriggerEvent>> SqlTriggerEventActions = new List<Action<SqlTriggerEvent>>();
        public void Register(Action<SqlTriggerEvent> action)
        {
            this.SqlTriggerEventActions.Add(action);
        }

        public List<Action<SqlUdtInstanceDataMemberExpression>> SqlUdtInstanceDataMemberExpressionActions = new List<Action<SqlUdtInstanceDataMemberExpression>>();
        public void Register(Action<SqlUdtInstanceDataMemberExpression> action)
        {
            this.SqlUdtInstanceDataMemberExpressionActions.Add(action);
        }

        public List<Action<SqlUdtInstanceMethodExpression>> SqlUdtInstanceMethodExpressionActions = new List<Action<SqlUdtInstanceMethodExpression>>();
        public void Register(Action<SqlUdtInstanceMethodExpression> action)
        {
            this.SqlUdtInstanceMethodExpressionActions.Add(action);
        }

        public List<Action<SqlUdtStaticDataMemberExpression>> SqlUdtStaticDataMemberExpressionActions = new List<Action<SqlUdtStaticDataMemberExpression>>();
        public void Register(Action<SqlUdtStaticDataMemberExpression> action)
        {
            this.SqlUdtStaticDataMemberExpressionActions.Add(action);
        }

        public List<Action<SqlUdtStaticMethodExpression>> SqlUdtStaticMethodExpressionActions = new List<Action<SqlUdtStaticMethodExpression>>();
        public void Register(Action<SqlUdtStaticMethodExpression> action)
        {
            this.SqlUdtStaticMethodExpressionActions.Add(action);
        }

        public List<Action<SqlUnaryScalarExpression>> SqlUnaryScalarExpressionActions = new List<Action<SqlUnaryScalarExpression>>();
        public void Register(Action<SqlUnaryScalarExpression> action)
        {
            this.SqlUnaryScalarExpressionActions.Add(action);
        }

        public List<Action<SqlUniqueConstraint>> SqlUniqueConstraintActions = new List<Action<SqlUniqueConstraint>>();
        public void Register(Action<SqlUniqueConstraint> action)
        {
            this.SqlUniqueConstraintActions.Add(action);
        }

        public List<Action<SqlUnpivotClause>> SqlUnpivotClauseActions = new List<Action<SqlUnpivotClause>>();
        public void Register(Action<SqlUnpivotClause> action)
        {
            this.SqlUnpivotClauseActions.Add(action);
        }

        public List<Action<SqlUnpivotTableExpression>> SqlUnpivotTableExpressionActions = new List<Action<SqlUnpivotTableExpression>>();
        public void Register(Action<SqlUnpivotTableExpression> action)
        {
            this.SqlUnpivotTableExpressionActions.Add(action);
        }

        public List<Action<SqlUnqualifiedJoinTableExpression>> SqlUnqualifiedJoinTableExpressionActions = new List<Action<SqlUnqualifiedJoinTableExpression>>();
        public void Register(Action<SqlUnqualifiedJoinTableExpression> action)
        {
            this.SqlUnqualifiedJoinTableExpressionActions.Add(action);
        }

        public List<Action<SqlUpdateBooleanExpression>> SqlUpdateBooleanExpressionActions = new List<Action<SqlUpdateBooleanExpression>>();
        public void Register(Action<SqlUpdateBooleanExpression> action)
        {
            this.SqlUpdateBooleanExpressionActions.Add(action);
        }

        public List<Action<SqlUpdateMergeAction>> SqlUpdateMergeActionActions = new List<Action<SqlUpdateMergeAction>>();
        public void Register(Action<SqlUpdateMergeAction> action)
        {
            this.SqlUpdateMergeActionActions.Add(action);
        }

        public List<Action<SqlUpdateSpecification>> SqlUpdateSpecificationActions = new List<Action<SqlUpdateSpecification>>();
        public void Register(Action<SqlUpdateSpecification> action)
        {
            this.SqlUpdateSpecificationActions.Add(action);
        }

        public List<Action<SqlUserDefinedScalarFunctionCallExpression>> SqlUserDefinedScalarFunctionCallExpressionActions = new List<Action<SqlUserDefinedScalarFunctionCallExpression>>();
        public void Register(Action<SqlUserDefinedScalarFunctionCallExpression> action)
        {
            this.SqlUserDefinedScalarFunctionCallExpressionActions.Add(action);
        }

        public List<Action<SqlValuesInsertMergeActionSource>> SqlValuesInsertMergeActionSourceActions = new List<Action<SqlValuesInsertMergeActionSource>>();
        public void Register(Action<SqlValuesInsertMergeActionSource> action)
        {
            this.SqlValuesInsertMergeActionSourceActions.Add(action);
        }

        public List<Action<SqlVariableColumnAssignment>> SqlVariableColumnAssignmentActions = new List<Action<SqlVariableColumnAssignment>>();
        public void Register(Action<SqlVariableColumnAssignment> action)
        {
            this.SqlVariableColumnAssignmentActions.Add(action);
        }

        public List<Action<SqlVariableDeclaration>> SqlVariableDeclarationActions = new List<Action<SqlVariableDeclaration>>();
        public void Register(Action<SqlVariableDeclaration> action)
        {
            this.SqlVariableDeclarationActions.Add(action);
        }

        public List<Action<SqlViewDefinition>> SqlViewDefinitionActions = new List<Action<SqlViewDefinition>>();
        public void Register(Action<SqlViewDefinition> action)
        {
            this.SqlViewDefinitionActions.Add(action);
        }

        public List<Action<SqlWhereClause>> SqlWhereClauseActions = new List<Action<SqlWhereClause>>();
        public void Register(Action<SqlWhereClause> action)
        {
            this.SqlWhereClauseActions.Add(action);
        }


        public List<Action<SqlXmlNamespacesDeclaration>> SqlXmlNamespacesDeclarationActions = new List<Action<SqlXmlNamespacesDeclaration>>();
        public void Register(Action<SqlXmlNamespacesDeclaration> action)
        {
            this.SqlXmlNamespacesDeclarationActions.Add(action);
        }
        #endregion

        #region Visits
        public void Visit(SqlAlterFunctionStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlAlterFunctionStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlAlterLoginStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlAlterLoginStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlAlterProcedureStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlAlterProcedureStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlAlterTriggerStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlAlterTriggerStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlAlterViewStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlAlterViewStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupCertificateStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupCertificateStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupDatabaseStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupDatabaseStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupLogStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupLogStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupMasterKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupMasterKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupServiceMasterKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupServiceMasterKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBackupTableStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBackupTableStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlBreakStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlBreakStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCommentStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCommentStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCompoundStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCompoundStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlContinueStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlContinueStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateFunctionStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateFunctionStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateIndexStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateIndexStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateLoginFromAsymKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateLoginFromAsymKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateLoginFromCertificateStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateLoginFromCertificateStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateLoginFromWindowsStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateLoginFromWindowsStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateLoginWithPasswordStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateLoginWithPasswordStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateProcedureStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateProcedureStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateRoleStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateRoleStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateSchemaStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateSchemaStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateSynonymStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateSynonymStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateTableStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateTableStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateTriggerStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateTriggerStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserDefinedDataTypeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserDefinedDataTypeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserDefinedTableTypeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserDefinedTableTypeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserDefinedTypeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserDefinedTypeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserFromAsymKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserFromAsymKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserFromCertificateStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserFromCertificateStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserWithImplicitAuthenticationStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserWithImplicitAuthenticationStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserFromLoginStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserFromLoginStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserFromExternalProviderStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserFromExternalProviderStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateUserWithoutLoginStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateUserWithoutLoginStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCreateViewStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCreateViewStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlCursorDeclareStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlCursorDeclareStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDBCCStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDBCCStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDeleteStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDeleteStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDenyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDenyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropAggregateStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropAggregateStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropDatabaseStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropDatabaseStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropDefaultStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropDefaultStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropFunctionStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropFunctionStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropLoginStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropLoginStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropProcedureStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropProcedureStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropRuleStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropRuleStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropSchemaStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropSchemaStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropSecurityPolicyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropSecurityPolicyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropSequenceStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropSequenceStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropSynonymStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropSynonymStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropTableStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropTableStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropTriggerStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropTriggerStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropTypeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropTypeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropUserStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropUserStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlDropViewStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlDropViewStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlExecuteModuleStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlExecuteModuleStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlExecuteStringStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlExecuteStringStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlGrantStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlGrantStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlIfElseStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlIfElseStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlInlineTableVariableDeclareStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlInlineTableVariableDeclareStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlInsertStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlInsertStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlMergeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlMergeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreDatabaseStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreDatabaseStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreInformationStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreInformationStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreLogStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreLogStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreMasterKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreMasterKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreServiceMasterKeyStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreServiceMasterKeyStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRestoreTableStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRestoreTableStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlReturnStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlReturnStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlRevokeStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlRevokeStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlSelectStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlSelectStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlSetAssignmentStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlSetAssignmentStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlSetStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlSetStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlTryCatchStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlTryCatchStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlUpdateStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlUpdateStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlUseStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlUseStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlVariableDeclareStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlVariableDeclareStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlWhileStatement statement)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(statement);
            }
            foreach (var action in SqlWhileStatementActions)
            {
                action(statement);
            }
        }
        public void Visit(SqlAggregateFunctionCallExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAggregateFunctionCallExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlAllAnyComparisonBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAllAnyComparisonBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlAllowPageLocksIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAllowPageLocksIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlAllowRowLocksIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAllowRowLocksIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlAssignment codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAssignmentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlAtTimeZoneExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlAtTimeZoneExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBatch codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBatchActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBetweenBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBetweenBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBinaryBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBinaryBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBinaryFilterExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBinaryFilterExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBinaryQueryExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBinaryQueryExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBinaryScalarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBinaryScalarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBooleanFilterExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBooleanFilterExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBuiltinScalarFunctionCallExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBuiltinScalarFunctionCallExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCastExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCastExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlChangeTrackingContext codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlChangeTrackingContextActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCheckConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCheckConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlClrAssemblySpecifier codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlClrAssemblySpecifierActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlClrClassSpecifier codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlClrClassSpecifierActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlClrFunctionBodyDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlClrFunctionBodyDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlClrMethodSpecifier codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlClrMethodSpecifierActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCollateScalarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCollateScalarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCollation codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCollationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlColumnAssignment codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlColumnAssignmentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDefaultConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDefaultConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlColumnDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlColumnDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlColumnIdentity codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlColumnIdentityActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlColumnRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlColumnRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCommonTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCommonTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlComparisonBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlComparisonBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCompressionPartitionRange codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCompressionPartitionRangeActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlComputedColumnDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlComputedColumnDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlConditionClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlConditionClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlConvertExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlConvertExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCreateUserOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCreateUserOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCubeGroupByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCubeGroupByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCursorOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCursorOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCursorVariableAssignment codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCursorVariableAssignmentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCursorVariableRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCursorVariableRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDataCompressionIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDataCompressionIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDataType codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDataTypeActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDataTypeSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDataTypeSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDdlTriggerDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDdlTriggerDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDefaultValuesInsertMergeActionSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDefaultValuesInsertMergeActionSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDefaultValuesInsertSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDefaultValuesInsertSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDeleteMergeAction codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDeleteMergeActionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDeleteSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDeleteSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDerivedTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDerivedTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDmlSpecificationTableSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDmlSpecificationTableSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDmlTriggerDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDmlTriggerDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlDropExistingIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlDropExistingIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlExecuteArgument codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlExecuteArgumentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlExecuteAsClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlExecuteAsClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlExistsBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlExistsBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFillFactorIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFillFactorIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFilterClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFilterClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForBrowseClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForBrowseClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForeignKeyConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForeignKeyConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlAutoClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlAutoClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlDirective codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlDirectiveActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlExplicitClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlExplicitClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlPathClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlPathClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlForXmlRawClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlForXmlRawClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFromClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFromClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFullTextBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFullTextBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFullTextColumn codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFullTextColumnActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGlobalScalarVariableRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGlobalScalarVariableRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGrandTotalGroupByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGrandTotalGroupByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGrandTotalGroupingSet codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGrandTotalGroupingSetActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGroupByClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGroupByClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGroupBySets codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGroupBySetsActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlGroupingSetItemsCollection codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlGroupingSetItemsCollectionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlHavingClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlHavingClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIdentifier codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIdentifierActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIdentityFunctionCallExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIdentityFunctionCallExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIgnoreDupKeyIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIgnoreDupKeyIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInBooleanExpressionCollectionValue codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInBooleanExpressionCollectionValueActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInBooleanExpressionQueryValue codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInBooleanExpressionQueryValueActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIndexedColumn codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIndexedColumnActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIndexHint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIndexHintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInlineIndexConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInlineIndexConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInlineFunctionBodyDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInlineFunctionBodyDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInlineTableRelationalFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInlineTableRelationalFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInlineTableVariableDeclaration codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInlineTableVariableDeclarationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInsertMergeAction codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInsertMergeActionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInsertSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInsertSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIntoClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIntoClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlIsNullBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlIsNullBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlLargeDataStorageInformation codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlLargeDataStorageInformationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlLikeBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlLikeBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlLiteralExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlLiteralExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlLoginPassword codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlLoginPasswordActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMaxDegreeOfParallelismIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMaxDegreeOfParallelismIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMergeActionClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMergeActionClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMergeSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMergeSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlInsertSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlInsertSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleCalledOnNullInputOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleCalledOnNullInputOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleEncryptionOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleEncryptionOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleExecuteAsOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleExecuteAsOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleNativeCompilationOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleNativeCompilationOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleRecompileOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleRecompileOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleReturnsNullOnNullInputOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleReturnsNullOnNullInputOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleSchemaBindingOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleSchemaBindingOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlModuleViewMetadataOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlModuleViewMetadataOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMultistatementFunctionBodyDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMultistatementFunctionBodyDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMultistatementTableRelationalFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMultistatementTableRelationalFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlNotBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlNotBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlQueryExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlQueryExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlObjectIdentifier codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlObjectIdentifierActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlObjectReference codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlObjectReferenceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOnlineIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOnlineIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOptimizeForSequentialKeyIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOptimizeForSequentialKeyIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlResumableIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlResumableIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlBucketCountIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlBucketCountIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlCompressionDelayIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlCompressionDelayIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlMaxDurationIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlMaxDurationIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOffsetFetchClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOffsetFetchClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOrderByClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOrderByClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOrderByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOrderByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOutputClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOutputClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlOutputIntoClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlOutputIntoClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlPadIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlPadIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlParameterDeclaration codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlParameterDeclarationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlPivotClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlPivotClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlPivotTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlPivotTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlPrimaryKeyConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlPrimaryKeyConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlStorageSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlStorageSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlProcedureDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlProcedureDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlQualifiedJoinTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlQualifiedJoinTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlQuerySpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlQuerySpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlQueryWithClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlQueryWithClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlRollupGroupByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlRollupGroupByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlRowConstructorExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlRowConstructorExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarClrFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarClrFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarFunctionReturnType codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarFunctionReturnTypeActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarRelationalFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarRelationalFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarSubQueryExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarSubQueryExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarVariableAssignment codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarVariableAssignmentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScalarVariableRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScalarVariableRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlScript codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlScriptActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSearchedCaseExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSearchedCaseExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSearchedWhenClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSearchedWhenClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectIntoClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectIntoClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectScalarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectScalarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectSpecificationInsertSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectSpecificationInsertSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectStarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectStarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSelectVariableAssignmentExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSelectVariableAssignmentExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSetClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSetClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSimpleCaseExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSimpleCaseExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSimpleGroupByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSimpleGroupByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSimpleOrderByClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSimpleOrderByClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSimpleOrderByItem codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSimpleOrderByItemActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSimpleWhenClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSimpleWhenClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSortedDataIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSortedDataIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSortedDataReorgIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSortedDataReorgIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlSortInTempDbIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlSortInTempDbIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlStatisticsIncrementalIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlStatisticsIncrementalIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlStatisticsNoRecomputeIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlStatisticsNoRecomputeIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlStatisticsOnlyIndexOption codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlStatisticsOnlyIndexOptionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableClrFunctionDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableClrFunctionDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableConstructorExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableConstructorExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableConstructorInsertSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableConstructorInsertSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableFunctionReturnType codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableFunctionReturnTypeActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableHint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableHintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableValuedFunctionRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableValuedFunctionRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableVariableRefExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableVariableRefExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTableUdtInstanceMethodExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTableUdtInstanceMethodExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTargetTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTargetTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTemporalPeriodDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTemporalPeriodDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTopSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTopSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTriggerAction codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTriggerActionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTriggerDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTriggerDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlTriggerEvent codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlTriggerEventActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUdtInstanceDataMemberExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUdtInstanceDataMemberExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUdtInstanceMethodExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUdtInstanceMethodExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUdtStaticDataMemberExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUdtStaticDataMemberExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUdtStaticMethodExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUdtStaticMethodExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUnaryScalarExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUnaryScalarExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUniqueConstraint codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUniqueConstraintActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUnpivotClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUnpivotClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUnpivotTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUnpivotTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUnqualifiedJoinTableExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUnqualifiedJoinTableExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUpdateBooleanExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUpdateBooleanExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUpdateMergeAction codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUpdateMergeActionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUpdateSpecification codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUpdateSpecificationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlUserDefinedScalarFunctionCallExpression codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlUserDefinedScalarFunctionCallExpressionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlValuesInsertMergeActionSource codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlValuesInsertMergeActionSourceActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlVariableColumnAssignment codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlVariableColumnAssignmentActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlVariableDeclaration codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlVariableDeclarationActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlViewDefinition codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlViewDefinitionActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlWhereClause codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlWhereClauseActions)
            {
                action(codeObject);
            }
        }
        public void Visit(SqlXmlNamespacesDeclaration codeObject)
        {
            foreach (var action in SqlCodeObjectActions)
            {
                action(codeObject);
            }
            foreach (var action in SqlXmlNamespacesDeclarationActions)
            {
                action(codeObject);
            }
        }
        #endregion
    }
}
