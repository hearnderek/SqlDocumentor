using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSqlDocumentor
{
    [TestClass]
    public class UnitTests
    {
        public void RunProgram(string query)
        {
            SqlDocumentor.Program.Main(new string[] { query });
        }

        [TestMethod]
        public void JustRun()
        {
            SqlDocumentor.Program.Parse("");
        }


        [TestMethod]
        public void SimpleStarQuery()
        {
            RunProgram(ValidQueries.SimpleStar);
        }

        [TestMethod]
        public void TwoSimpleStarQuerys()
        {
            RunProgram(ValidQueries.TwoSimpleStar);
        }

        [TestMethod]
        public void TwoSimpleStarQuerysSeperatedWithGO()
        {
            RunProgram(ValidQueries.GoSeperatedTwoSimpleStar);
        }

        [TestMethod]
        public void ProduceError()
        {
            string query = "This is just a normal sentence, thus it should produce a parse error.";
            // All the info is in colsole out
            RunProgram(query);

        }

        [TestMethod]
        public void ManySelectOneColumn()
        {
            // Want to see how theses nearly identical queries 
            string query = ValidQueries.GoSeperatedSimple;
            RunProgram(query);
        }

        [TestMethod]
        public void CTEQuery()
        {
            string query = ValidQueries.SimpleCTE;
            RunProgram(query);
        }

        [TestMethod]
        public void SubSelectQuery()
        {
            string query = ValidQueries.SimpleSubscript;
            RunProgram(query);
        }

        [TestMethod]
        public void walk()
        {
            string query = ValidQueries.SimpleSubscript;
            SqlDocumentor.Program.walkTree(query);
        }

        [TestMethod]
        public void ScriptICareAbout()
        {
            string query = ValidQueries.ScriptICareAbout;
            var script =  new SqlDocumentor.ScriptICareAbout(query, "localhost", "master");
            var cols = script.GetSelectedColumns();
            foreach (SqlDocumentor.SelectedColumn col in cols)
            {
                Console.WriteLine($"identifier: {col.ColumnIdentifier}");
                foreach (var refColumn in col.RefColumns)
                {
                    Console.WriteLine($"ref: {String.Join(".", refColumn.references)} -> {refColumn.ColumnName}");
                }
                Console.WriteLine(col.calculation);
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void ScriptICareAbout2()
        {
            string query = ValidQueries.ScriptICareAbout2;
            var script = new SqlDocumentor.ScriptICareAbout(query, "localhost", "master");
            var cols = script.GetSelectedColumns();
            foreach (SqlDocumentor.SelectedColumn col in cols)
            {
                Console.WriteLine($"identifier: {col.ColumnIdentifier}");
                foreach (var refColumn in col.RefColumns)
                {
                    Console.WriteLine($"ref: {String.Join(".", refColumn.references)} -> {refColumn.ColumnName}");
                }
                Console.WriteLine(col.calculation);
                Console.WriteLine();
            }
        }

        [TestMethod]
        public void TestValidQueries()
        {
            foreach(string query in ValidQueries.GetAll())
            {
                SqlDocumentor.Program.ParsesWithNoErrorsOrWarnings(query);
            }
        }

        [TestMethod]
        public void TestBind()
        {
            SqlDocumentor.Program.ParseAndBindMetaData(ValidQueries.SimpleCTE, "DESKTOP-B9Q49UJ", "master");
        }


        [TestMethod]
        public void SelectStatementWithinFunctionCannotReturnData()
        {
            string query = ValidQueriesAdventureWorks.Sample1;
            var script = new SqlDocumentor.ScriptICareAbout(query, "localhost", "AdventureWorksLT2019");
            var cols = script.GetSelectedColumns();

            var boundObjs = SqlDocumentor.FindBoundTreeWalker.walkTree(script.script);
            foreach (var boundObj in boundObjs)
            {
                Console.WriteLine($"Bound Object: {boundObj.BoundObject.Name}");
            }

            foreach (SqlDocumentor.SelectedColumn col in cols)
            {
                Console.WriteLine($"identifier: {col.ColumnIdentifier}");
                foreach (var refColumn in col.RefColumns)
                {
                    Console.WriteLine($"ref: {String.Join(".", refColumn.references)} -> {refColumn.ColumnName}");
                }
                Console.WriteLine(col.calculation);
                Console.WriteLine();
            }
        }

    }
}
