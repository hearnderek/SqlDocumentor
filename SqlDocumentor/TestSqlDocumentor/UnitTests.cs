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
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }


        [TestMethod]
        public void HelloWorldRef()
        {
            SqlDocumentor.Program.HelloWorld();
        }

        [TestMethod]
        public void JustRun()
        {
            SqlDocumentor.Program.Parse("");
        }


        [TestMethod]
        public void SimpleStarQuery()
        {
            string query = "Select * from INFORMATION_SCHEMA";
            RunProgram(query);
        }

        [TestMethod]
        public void ProduceError()
        {
            string query = "This is just a normal sentence, thus it should produce a parse error.";
            RunProgram(query);

        }
    }
}
