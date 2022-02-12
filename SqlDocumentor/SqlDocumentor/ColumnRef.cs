using System.Linq;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    public class ColumnRef
    {
        public string ColumnName;
        public string[] references;

        //public static ColumnRef From(SqlColumnRefExpression refExpression)
        //{
        //    var cr = new ColumnRef();
        //    var walked = TakingTreeWalker.walkTree<SqlIdentifier>(refExpression);
        //    cr.ColumnName = walked.Last().Value;
        //    cr.references = TakingTreeWalker.walkTree<SqlIdentifier>(refExpression)
        //        // Drop last -- that will be the column name
        //        .Reverse().Skip(1).Reverse()
        //        // Extract Name
        //        .Select(id=>id.Value)
        //        .ToArray();
        //    return cr;
        //}

        public static ColumnRef From(SqlScalarRefExpression refExpression)
        {
            var cr = new ColumnRef();
            var walked = TakingTreeWalker.walkTree<SqlIdentifier>(refExpression);
            cr.ColumnName = walked.Last().Value;
            cr.references = TakingTreeWalker.walkTree<SqlIdentifier>(refExpression)
                // Drop last -- that will be the column name
                .Reverse().Skip(1).Reverse()
                // Extract Name
                .Select(id => id.Value)
                .ToArray();
            return cr;
        }
    }
}
