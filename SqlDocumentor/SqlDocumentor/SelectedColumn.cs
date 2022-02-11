using System.Linq;
using System.Collections.Generic;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    public class SelectedColumn
    {
        public string ColumnIdentifier;
        public string calculation;
        public ColumnRef[] RefColumns;


        public static SelectedColumn From(SqlSelectScalarExpression expression)
        {
            string columnName = null;

            // get column name
            if (expression.Alias != null)
            {
                columnName = expression.Alias.Value;
                // What is expression.Alias.BoundObject?
            }
            else
            {
                columnName = TakingTreeWalker.walkTree<SqlIdentifier>(expression).Last().Value;
            }

            IEnumerable<SqlColumnRefExpression> refs = TakingTreeWalker.walkTree<SqlColumnRefExpression>(expression);
            ColumnRef[] columns = refs
                .Select(ColumnRef.From)
                .ToArray();

            if (columns.Length == 0)
            {
                IEnumerable<SqlScalarRefExpression> scalarRefs = TakingTreeWalker.walkTree<SqlScalarRefExpression>(expression);
                columns = scalarRefs
                    .Select(ColumnRef.From)
                    .ToArray();
            }

            return new SelectedColumn()
            {
                ColumnIdentifier = columnName,
                calculation = expression.Sql,
                RefColumns = columns
            };
        }

        public static SelectedColumn From(SqlSelectStarExpression expression)
        {
            string ColumnIdentifier = "*";
            string calculation = expression.Sql;

            ColumnRef[] refColumns = expression.Qualifier?.Select(c => new ColumnRef()
            {
                ColumnName = "*",
                references = new string[] { c.Value }.Where(s=>s!=null).ToArray()
            }).ToArray();


            // TODO get table

            return new SelectedColumn() { 
                ColumnIdentifier = ColumnIdentifier,
                calculation = expression.Sql,
                RefColumns = refColumns ?? new ColumnRef[0]
            };
        }
    }
}
