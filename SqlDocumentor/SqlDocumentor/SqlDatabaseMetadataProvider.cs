using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.SqlParser.Metadata;
using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;

namespace SqlDocumentor
{
    public class SqlDatabaseMetadataProvider : IMetadataProvider
    {
        private readonly MetadataFactory _metadataFactory;
        public readonly CollationInfo Collation = CollationInfo.Default;
        public readonly IMutableServer server;
        public readonly IMutableDatabase database;

        public Dictionary<string, IMutableSchema> SchemaMetadataLookup = new Dictionary<string, IMutableSchema>(StringComparer.InvariantCultureIgnoreCase);
        public Dictionary<string, IMutableTable> TableMetadataLookup = new Dictionary<string, IMutableTable>(StringComparer.InvariantCultureIgnoreCase);
        public Dictionary<string, IMutableView> ViewMetadataLookup = new Dictionary<string, IMutableView>(StringComparer.InvariantCultureIgnoreCase);


        public SqlDatabaseMetadataProvider(string serverInstance, string databaseName)
        {
            _metadataFactory = new MetadataFactory();
            server = _metadataFactory.Server.Create(serverInstance, CollationInfo.Default);
            database = _metadataFactory.Database.Create(server, databaseName, CollationInfo.Default);
            server.Databases.Append(database);
        }

        public void PopulateAll()
        {
            PopulateTables();
            PopulateViews();
            PopulatedStoredProcedures();
        }

        public void PopulateTables()
        {
            string query = @"
SELECT TABLES.TABLE_SCHEMA, TABLES.TABLE_NAME, COLUMNS.COLUMN_NAME
FROM INFORMATION_SCHEMA.TABLES
LEFT JOIN INFORMATION_SCHEMA.COLUMNS on 
	COLUMNS.TABLE_SCHEMA = TABLES.TABLE_SCHEMA AND
	COLUMNS.TABLE_NAME = TABLES.TABLE_NAME
";

            string serverName = server.Name;
            string databaseName = database.Name;

            using (var connection = new SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", serverName, databaseName)))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var schemaName = reader.GetString(0);
                        var tableName = reader.GetString(1);
                        var columnName = reader.GetString(2);

                        // Get Schema
                        if (!SchemaMetadataLookup.ContainsKey(schemaName))
                        {
                            SchemaMetadataLookup[schemaName] = _metadataFactory.Schema.Create(database, schemaName);
                            database.Schemas[schemaName] = SchemaMetadataLookup[schemaName];
                        }
                        var schema = SchemaMetadataLookup[schemaName];

                        // Get Table
                        if (!TableMetadataLookup.ContainsKey(tableName))
                        {
                            TableMetadataLookup[tableName] = _metadataFactory.Tabular.CreateTable(schema, tableName);
                            // Of course we can't actually append anything to these objects..
                            schema.Tables.Add(TableMetadataLookup[tableName]);
                        }
                        var table = TableMetadataLookup[tableName];

                        var column = _metadataFactory.Column.Create(table, columnName);
                        table.Columns.Add(column);
                    }
                }
            }
        }

        public void PopulateViews()
        {
            string query = @"
SELECT VIEWS.TABLE_SCHEMA, VIEWS.TABLE_NAME, COLUMNS.COLUMN_NAME
FROM INFORMATION_SCHEMA.VIEWS
LEFT JOIN INFORMATION_SCHEMA.COLUMNS on 
	COLUMNS.TABLE_SCHEMA = VIEWS.TABLE_SCHEMA AND
	COLUMNS.TABLE_NAME = VIEWS.TABLE_NAME
";

            string serverName = server.Name;
            string databaseName = database.Name;

            using (var connection = new SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", serverName, databaseName)))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var schemaName = reader.GetString(0);
                        var viewName = reader.GetString(1);
                        var columnName = reader.GetString(2);

                        // Get Schema
                        if (!SchemaMetadataLookup.ContainsKey(schemaName))
                        {
                            SchemaMetadataLookup[schemaName] = _metadataFactory.Schema.Create(database, schemaName);
                            database.Schemas.Add(SchemaMetadataLookup[schemaName]);
                        }
                        var schema = SchemaMetadataLookup[schemaName];

                        // Get Table
                        if (!ViewMetadataLookup.ContainsKey(viewName))
                        {
                            ViewMetadataLookup[viewName] = _metadataFactory.Tabular.CreateView(schema, viewName);
                            schema.Views.Add(ViewMetadataLookup[viewName]);
                        }
                        var table = ViewMetadataLookup[viewName];

                        var column = _metadataFactory.Column.Create(table, columnName);
                        table.Columns.Add(column);
                    }
                }
            }
        }

        public void PopulatedStoredProcedures()
        {

        }

        /// --- IMetadataProvider Section ---
        /// 
        /// Honestly I don't think I need this, but I feel like this is what I'm reimplementing here.
        /// It is a shame that I couldn't figure out how to use their implementation of this.


        public IServer Server => this.server;

        public IBuiltInFunctionLookup BuiltInFunctionLookup => throw new NotImplementedException();

        public ICollationLookup CollationLookup => throw new NotImplementedException();

        public ISystemDataTypeLookup SystemDataTypeLookup => throw new NotImplementedException();

        public IMetadataFactory MetadataFactory => this._metadataFactory;

        public MetadataProviderEventHandler BeforeBindHandler => throw new NotImplementedException();

        public MetadataProviderEventHandler AfterBindHandler => throw new NotImplementedException();

        
    }
}
