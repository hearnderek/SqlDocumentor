using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.SqlParser;
using Microsoft.SqlServer.Management.SqlParser.Parser;

namespace SqlDocumentor
{
    public class Program
    {
        static string GoalOfProject = @"

The primary goal of the project is to get more familier with Microsoft.SqlServer.Management.SqlParser
The secondary goal of the project is to build a tool that can document the computation flow through a complex SQL Script
   
";

        public static void Main(string[] args)
        {
            Console.WriteLine(GoalOfProject.Trim());

            if (args.Length == 0)
                return;

            string query = args[0];
            //new ParseOptions()
            Parse(query);
        }

        public static void HelloWorld()
        {
            Console.WriteLine(GoalOfProject);
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
        }
    }
}
