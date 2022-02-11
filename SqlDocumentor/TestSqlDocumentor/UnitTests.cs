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
            string query = "Select * from INFORMATION_SCHEMA.tables";
            RunProgram(query);
        }

        [TestMethod]
        public void TwoSimpleStarQuerys()
        {
            string query = @"
Select * from INFORMATION_SCHEMA.tables
Select * from INFORMATION_SCHEMA.views
";
            RunProgram(query);
        }

        [TestMethod]
        public void TwoSimpleStarQuerysSeperatedWithGO()
        {
            string query = @"
Select * from INFORMATION_SCHEMA.tables
GO
Select * from INFORMATION_SCHEMA.views
";
            RunProgram(query);
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
            string query = @"
Select TABLE_NAME from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME from INFORMATION_SCHEMA.tables as t
GO
Select TABLE_NAME from INFORMATION_SCHEMA.tables t
GO
Select TABLE_NAME as [tbl] from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME as tbl from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME [tbl] from INFORMATION_SCHEMA.tables
GO
Select TABLE_NAME tbl from INFORMATION_SCHEMA.tables
";
            RunProgram(query);
        }
    }
}
