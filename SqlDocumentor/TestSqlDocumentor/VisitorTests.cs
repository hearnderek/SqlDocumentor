using Microsoft.SqlServer.Management.SqlParser.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestSqlDocumentor
{
    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        public void PrintVisitor()
        {
            ParseResult parseResult = Parser.Parse(ValidQueriesAdventureWorks.Batched1);
            var myVisitor = new MySqlVisitor();
            
            var theVisitor = new SqlCodeObjectVisitorRegistry();
            theVisitor.RegisterForAll(theVisitor.VisitAllChildren);
            theVisitor.RegisterForAll(sqlCodeObject => System.Console.WriteLine(sqlCodeObject));

            parseResult.Script.Accept(theVisitor);
            //parseResult.Script.

        }
    }
}
