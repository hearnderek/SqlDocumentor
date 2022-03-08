using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.SqlParser.Parser;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;
using Microsoft.SqlServer.Management.SqlParser.Binder;
using Microsoft.SqlServer.Management.SqlParser.Metadata;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;


namespace SqlDocumentor
{
    //public class PrintVisitor : SqlCodeObjectRecursiveVisitor
    //{
    //    public virtual void Visit(SqlSelectClause codeObject, C context) => this.VisitList<SqlCodeObject>(codeObject.Children, context);
    //}
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


        public static void ParseAndBindMetaData(string query, string server, string database)
        {
            //var exServer = new 
            ParseResult parseResult = Parser.Parse(query);


            // Using these objects I can build up a representation of the database...
            var provider = new SqlDatabaseMetadataProvider(server, database);
            provider.PopulateAll();
            
            foreach(var table in provider.database.Schemas.First().Tables)
            {
                Console.WriteLine($"Table: {table.Name}");

                foreach(var column in table.Columns)
                {
                    Console.WriteLine($"- Column: {column.Name}");
                }

            }


            IBinder binder = BinderProvider.CreateBinder(provider);

            //// Building up my own representation of the server data
            //IMutableServer serverObj = metadataFactory.Server.Create(server, CollationInfo.Default);
            //var dbObj = metadataFactory.Database.Create(serverObj, database, CollationInfo.Default);
            //serverObj.Databases.Add(dbObj);

            //// Get All Schemas



            //var schemaDbo = metadataFactory.Schema.Create(dbObj, "dbo");
            //dbObj.Schemas.Add(schemaDbo);

            //// Get All Tables within Schema
            //var table = metadataFactory.Tabular.CreateTable(schemaDbo, "table Name");
            //schemaDbo.Tables.Add(table);

            // Get all views in table






            //metadataProvider.AddMetadataForServer(server, database);
            //var metadata = metadataProvider.GetMetadata(parseResult);

            //// Get metadata from server
            //// Get metadata from database

            //// Get the sql code dom
            //SqlCodeObject sqlCodeObject = CodeDomGenerator.GenerateCode(bindResult);




            // IBinder binder = Microsoft.SqlServer.Management.SqlParser.Binder.


            // var provider = new Microsoft.SqlServer.Management.SqlParser.MetadataProvider.MetadataDisplayInfoProvider();


            //var displayInfoProvider = new Microsoft.SqlServer.Management.SqlParser.MetadataProvider.MetadataDisplayInfoProvider();

            //var methodNameAndParams = Microsoft.SqlServer.Management.SqlParser.Intellisense.Resolver.GetMethodNameAndParams(
            //    parseResult, 
            //    1, 
            //    1, 
            //    (Microsoft.SqlServer.Management.SqlParser.MetadataProvider.IMetadataDisplayInfoProvider)displayInfoProvider);
            //methodNameAndParams.

            /*
             System.InvalidCastException: '型 'Microsoft.SqlServer.Management.SqlParser.MetadataProvider.MetadataDisplayInfoProvider' 
            のオブジェクトを型 'Microsoft.SqlServer.Management.SqlParser.MetadataProvider.IMetadataProvider' にキャストできません。'
             */

            // No Options for these IMetadataProviders...
            // 1. DeserializationModel.ModelMetadataProvider in (M.SS.M.SP.MS.DM) INTERNAL

            //IBinder binder = BinderProvider.CreateBinder((Microsoft.SqlServer.Management.SqlParser.MetadataProvider.IMetadataProvider)provider);
            //IServer exServer = binder.Bind(new[] { parseResult }, server, BindMode.Build);


        }

        public static bool ParsesWithNoErrorsOrWarnings(string query)
        {
            ParseResult parseResult = Parser.Parse(query);
            return !parseResult.Errors.Any();
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

                //SqlModuleViewMetadataOption


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
