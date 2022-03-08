using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;

namespace TestSqlDocumentor
{

    public class MySqlVisitor : ISqlCodeObjectVisitor
    {


        public void Visit(SqlAggregateFunctionCallExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAllAnyComparisonBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAllowPageLocksIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAllowRowLocksIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAssignment codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAtTimeZoneExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBatch codeObject)
        {
            System.Console.WriteLine("At batch");
            System.Console.WriteLine(codeObject.Sql);
            System.Console.WriteLine("");
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBetweenBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBinaryBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBinaryFilterExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBinaryQueryExpression codeObject)
        {

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBinaryScalarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlBooleanFilterExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlBuiltinScalarFunctionCallExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCastExpression codeObject)
        {

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlChangeTrackingContext codeObject)
        {

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlCheckConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlClrAssemblySpecifier codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlClrClassSpecifier codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlClrFunctionBodyDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlClrMethodSpecifier codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCollateScalarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCollation codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlColumnAssignment codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlDefaultConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlColumnDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlColumnIdentity codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlColumnRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCommonTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlComparisonBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCompressionPartitionRange codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlComputedColumnDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlConditionClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlConstraint codeObject)
        {

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlConvertExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCreateUserOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCubeGroupByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCursorOption codeObject)
        {

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlCursorVariableAssignment codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);

        }

        public void Visit(SqlCursorVariableRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDataCompressionIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDataType codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDataTypeSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDdlTriggerDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDefaultValuesInsertMergeActionSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDefaultValuesInsertSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDeleteMergeAction codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDeleteSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDerivedTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDmlSpecificationTableSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDmlTriggerDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlDropExistingIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlExecuteArgument codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlExecuteAsClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlExistsBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFillFactorIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFilterClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForBrowseClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForeignKeyConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlAutoClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlDirective codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlExplicitClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlPathClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlForXmlRawClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFromClause codeObject)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("At FROM clause");
            System.Console.WriteLine(codeObject);

            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFullTextBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFullTextColumn codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGlobalScalarVariableRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGrandTotalGroupByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGrandTotalGroupingSet codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGroupByClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGroupBySets codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlGroupingSetItemsCollection codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlHavingClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIdentifier codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIdentityFunctionCallExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIgnoreDupKeyIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInBooleanExpressionCollectionValue codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInBooleanExpressionQueryValue codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIndexedColumn codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIndexHint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInlineIndexConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInlineFunctionBodyDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInlineTableRelationalFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInlineTableVariableDeclaration codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInsertMergeAction codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInsertSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIntoClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlIsNullBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlLargeDataStorageInformation codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlLikeBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlLiteralExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlLoginPassword codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMaxDegreeOfParallelismIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMergeActionClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMergeSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlInsertSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleCalledOnNullInputOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleEncryptionOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleExecuteAsOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleNativeCompilationOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleRecompileOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleReturnsNullOnNullInputOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleSchemaBindingOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlModuleViewMetadataOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMultistatementFunctionBodyDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMultistatementTableRelationalFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlNotBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlQueryExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlObjectIdentifier codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlObjectReference codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOnlineIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOptimizeForSequentialKeyIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlResumableIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlBucketCountIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlCompressionDelayIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlMaxDurationIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOffsetFetchClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOrderByClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOrderByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOutputClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlOutputIntoClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlPadIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlParameterDeclaration codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlPivotClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlPivotTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlPrimaryKeyConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlStorageSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlProcedureDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlQualifiedJoinTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlQuerySpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlQueryWithClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlRollupGroupByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlRowConstructorExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarClrFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarFunctionReturnType codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarRelationalFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarSubQueryExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarVariableAssignment codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScalarVariableRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlScript codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSearchedCaseExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSearchedWhenClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectIntoClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectScalarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectSpecificationInsertSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectStarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSelectVariableAssignmentExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSetClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSimpleCaseExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSimpleGroupByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSimpleOrderByClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSimpleOrderByItem codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSimpleWhenClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSortedDataIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSortedDataReorgIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlSortInTempDbIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlStatisticsIncrementalIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlStatisticsNoRecomputeIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlStatisticsOnlyIndexOption codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableClrFunctionDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableConstructorExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableConstructorInsertSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableFunctionReturnType codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableHint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableValuedFunctionRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableVariableRefExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTableUdtInstanceMethodExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTargetTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTemporalPeriodDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTopSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTriggerAction codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTriggerDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlTriggerEvent codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUdtInstanceDataMemberExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUdtInstanceMethodExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUdtStaticDataMemberExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUdtStaticMethodExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUnaryScalarExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUniqueConstraint codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUnpivotClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUnpivotTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUnqualifiedJoinTableExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUpdateBooleanExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUpdateMergeAction codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUpdateSpecification codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlUserDefinedScalarFunctionCallExpression codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlValuesInsertMergeActionSource codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlVariableColumnAssignment codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlVariableDeclaration codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlViewDefinition codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlWhereClause codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlXmlNamespacesDeclaration codeObject)
        {
            foreach (var child in codeObject.Children) child.Accept(this);
        }

        public void Visit(SqlAlterFunctionStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlAlterLoginStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlAlterProcedureStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlAlterTriggerStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlAlterViewStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupCertificateStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupDatabaseStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupLogStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupMasterKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupServiceMasterKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBackupTableStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlBreakStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCommentStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCompoundStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlContinueStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateFunctionStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateIndexStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateLoginFromAsymKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateLoginFromCertificateStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateLoginFromWindowsStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateLoginWithPasswordStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateProcedureStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateRoleStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateSchemaStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateSynonymStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateTableStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateTriggerStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserDefinedDataTypeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserDefinedTableTypeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserDefinedTypeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserFromAsymKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserFromCertificateStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserWithImplicitAuthenticationStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserFromLoginStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserFromExternalProviderStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateUserWithoutLoginStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCreateViewStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlCursorDeclareStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDBCCStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDeleteStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDenyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropAggregateStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropDatabaseStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropDefaultStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropFunctionStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropLoginStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropProcedureStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropRuleStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropSchemaStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropSecurityPolicyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropSequenceStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropSynonymStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropTableStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropTriggerStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropTypeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropUserStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlDropViewStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlExecuteModuleStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlExecuteStringStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlGrantStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlIfElseStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlInlineTableVariableDeclareStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlInsertStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlMergeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreDatabaseStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreInformationStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreLogStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreMasterKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreServiceMasterKeyStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRestoreTableStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlReturnStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlRevokeStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlSelectStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlSetAssignmentStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlSetStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlTryCatchStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlUpdateStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlUseStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlVariableDeclareStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }

        public void Visit(SqlWhileStatement statement)
        {
            foreach (var child in statement.Children) child.Accept(this);
        }
    }
}
