using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.SqlParser;
using Microsoft.SqlServer.Management.SqlParser.Parser;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    public class SqlTreeLocation
    {
        // NOT USED
        public int depth { get; private set; }
        public int tokenNumber { get; private set; }

        public Location location { get; private set; }

        public SqlTreeLocation(int depth, int tokenNumber, Location location)
        {
            this.depth = depth;
            this.tokenNumber = tokenNumber;
            this.location = location;
        }
    }


    public class Program
    {
        static string GoalOfProject = @"

The primary goal of the project is to get more familier with Microsoft.SqlServer.Management.SqlParser
The secondary goal of the project is to build a tool that can document the computation flow through a complex SQL Script
   
";

        public static void Main(string[] args)
        {
            //Console.WriteLine(GoalOfProject.Trim());

            if (args.Length == 0)
                return;

            string query = args[0];
            //new ParseOptions()
            Parse(query);
        }



        public static void Parse(string query)
        {
            ParseResult parseResult = Parser.Parse(query);

            if (parseResult.Errors.Any())
            {
                Console.WriteLine("We've had some issues when parsing the query");

                int i = 0;
                foreach (var error in parseResult.Errors)
                {
                    i++;
                    if (error.IsWarning)
                        Console.WriteLine($"[Warning {i}]");
                    else
                        Console.WriteLine($"[Error {i}]");

                    Location start = error.Start;
                    Console.WriteLine($"At Line: {start.LineNumber} and character: {start.ColumnNumber}");
                    Console.WriteLine(error.Message);

                }
            }
            else
            {
                //Console.WriteLine("Query was successfully parsed");

                //Console.WriteLine($"BatchCount: {parseResult.BatchCount}");

                SqlScript parsedScript = parseResult.Script;




                //WriteOutIdentifiers(parsedScript);
                //Console.WriteLine();
                Console.WriteLine(parsedScript.Xml);

            }
        }
        public static void walkTree(string script)
        {
            ParseResult parseResult = Parser.Parse(script);
            
            
            TreeWalker.walkTree(parseResult.Script, new[] {TreeWalker.PrintVisitor});
        }

        public static void DescribeSqlSelectStatement(SqlScript parsedScript)
        {
            IEnumerable<SqlCodeObject> children = parsedScript.Children;

        }

        private static void WriteOutIdentifiers(Microsoft.SqlServer.Management.SqlParser.SqlCodeDom.SqlScript parsedScript)
        {
            Console.WriteLine("\nWriting out all Identifiers");
            var identifiers = parsedScript.RetrieveAllIdentifiers();
            foreach (var iden in identifiers)
            {
                Console.WriteLine($"type: '{iden.GetType()}'");
                Console.WriteLine($"value: '{iden.Value}'");
            }
        }
    }
}
