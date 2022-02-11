using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    public class TreeWalker
    {
        public static void walkTree(SqlScript parsedScript, IEnumerable<Action<SqlCodeObject, int, int>> actions)
        {
            IEnumerable<SqlCodeObject> children = parsedScript.Children;
            int count = 0;
            foreach (SqlCodeObject child in children)
            {
                count++;
                walkTree(child, 1, ref count, actions);
            }
        }


        public static void walkTree(SqlCodeObject sqlCodeObject, int depth, ref int count, IEnumerable<Action<SqlCodeObject, int, int>> actions)
        {
            foreach (var action in actions)
            {
                action(sqlCodeObject, depth, count);
            }

            IEnumerable<SqlCodeObject> children = sqlCodeObject.Children;
            foreach (SqlCodeObject child in children)
            {
                count++;
                walkTree(child, depth + 1, ref count, actions);
            }

            
        }

        public static Action<SqlCodeObject, int, int> PrintVisitor => (sqlCodeObject, depth, count) => Console.WriteLine($"{sqlCodeObject.GetType()} ({depth}, {count})");

    }
}
