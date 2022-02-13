using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Management.SqlParser.Parser;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;
using Microsoft.SqlServer.Management.SqlParser.Binder;


namespace SqlDocumentor
{
    public class ScriptICareAbout
    {
        public readonly SqlScript script;

        public ScriptICareAbout(string query, string server, string database)
        {
            ParseResult[] parseResults = new[] { Parser.Parse(query) };
            var provider = new SqlDatabaseMetadataProvider(server, database);
            provider.PopulateAll();
            IBinder binder = BinderProvider.CreateBinder(provider);

            /* BIND ERROR
             * The 'SELECT' statement is not supported in a data-tier application. Remove the statement before rebuilding.
             * 
             * Sr.cs -> SelectStatementWithinFunctionCannotReturnData
             * used in ValidateModuleBodyVistor.cs
             * 
             * 
             * BindMode.Build vs BindMode.Batch
             * 
             * Looks like I need to use Batch for all of my simple scripts.
             * I'm guessing build has to do with internal SQL objects like views?
             * 
             * BoundObject is still null after binding...
             * But I'm no longer getting errors.
             */
            var bindResult = binder.Bind(parseResults, database, BindMode.Batch);
            var bo = parseResults[0].Script.BoundObject;
            script = parseResults[0].Script;


        }

        internal ScriptICareAbout(SqlScript script)
        {
            this.script = script;

        }

        /// <summary>
        /// Assuming the script is a plain query, get the final columns that are selected
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectedColumn> GetSelectedColumns()
        {
            // root/SqlBatch/SqlSelectStatement/SqlSelectSpecification/SqlQuerySpecification/SqlSelectClause/
            Type[] path = new[] {
                typeof(SqlBatch),
                typeof(SqlSelectStatement),
                typeof(SqlSelectSpecification),
                typeof(SqlQuerySpecification),
                typeof(SqlSelectClause),
            };

            // There will be only one (Assuming no GO usage)
            var sqlSelectStatement = (SqlSelectClause) SelectiveTreeWalker.walkTree(script, path).FirstOrDefault();
            if(sqlSelectStatement is null)
            {
                yield break;
            }

            var @switch = new Dictionary<Type, Func<SqlCodeObject, SelectedColumn>>
            {
                // As far as I've seen so far, these are the only two method of selecting a column
                // I'd expecting to possibly see something new when reviewing pivots
                {typeof(SqlSelectScalarExpression), (x)=>SelectedColumn.From((SqlSelectScalarExpression)x) },
                {typeof(SqlSelectStarExpression), (x)=>SelectedColumn.From((SqlSelectStarExpression)x) },
            };

            foreach(SqlCodeObject child in sqlSelectStatement.Children)
            {
                if (@switch.ContainsKey(child.GetType()))
                {
                    yield return @switch[child.GetType()](child);
                }
            }
        }
    }
}
