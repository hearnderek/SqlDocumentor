using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    /// <summary>
    /// Walk the tree, and perform actions on those nodes
    /// </summary>
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

    
    /// <summary>
    /// Take all end nodes that match the type path
    /// </summary>
    public class SelectiveTreeWalker
    {


        public static IEnumerable<SqlCodeObject> walkTree(SqlScript parsedScript, IEnumerable<Type> requiredPath)
        {
            IEnumerable<SqlCodeObject> children = parsedScript.Children;
            // Can't decide if I want to return everything after, or just to return the 
            Type t = requiredPath.Any() ? requiredPath.First() : null;
            foreach (SqlCodeObject child in children)
            {
                foreach (var obj in walkTree(child, requiredPath))
                {
                    yield return obj;
                }
            }
        }


        public static IEnumerable<SqlCodeObject> walkTree(SqlCodeObject sqlCodeObject, IEnumerable<Type> requiredPath)
        {
            Type t = requiredPath.Any() ? requiredPath.First() : null;


            if (!t.IsAssignableFrom(sqlCodeObject.GetType()))
            {
                yield break;
            }

            var shifted = requiredPath.Skip(1);
            if (shifted.Any())
            {
                IEnumerable<SqlCodeObject> children = sqlCodeObject.Children;
                foreach (SqlCodeObject child in children)
                {
                    foreach (SqlCodeObject obj in walkTree(child, shifted))
                    {
                        yield return obj;
                    }
                }
            }
            else
            {
                yield return sqlCodeObject;
            }


        }

    }



    /// <summary>
    /// Take every node that matches our generic type
    /// </summary>
    public class TakingTreeWalker
    {
        public static IEnumerable<T> walkTree<T>(SqlScript parsedScript) where T : SqlCodeObject
        {
            IEnumerable<SqlCodeObject> children = parsedScript.Children;
            // Can't decide if I want to return everything after, or just to return the 
            foreach (SqlCodeObject child in children)
            {
                foreach (var obj in walkTree<T>(child))
                {
                    yield return obj;
                }
            }
        }


        public static IEnumerable<T> walkTree<T>(SqlCodeObject sqlCodeObject) where T : SqlCodeObject
        {
            if (sqlCodeObject is T || typeof(T).IsAssignableFrom(sqlCodeObject.GetType()))
            {
                yield return (T) sqlCodeObject;
            }

            IEnumerable<SqlCodeObject> children = sqlCodeObject.Children;
            foreach (SqlCodeObject child in children)
            {
                foreach (T t in walkTree<T>(child))
                {
                    yield return t;
                }
            }


        }

    }
}
