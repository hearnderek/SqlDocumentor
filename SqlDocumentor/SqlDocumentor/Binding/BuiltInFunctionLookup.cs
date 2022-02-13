using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;

namespace SqlDocumentor.Binding
{
    /// <summary>
    /// This class only exists because I want to Bind my SqlDatabaseMetadataProvider, and I need to implement the whole interface.
    /// </summary>
    internal class BuiltInFunctionLookup : BuiltInFunctionLookupBase
    {
        public static IBuiltInFunctionLookup Instance => Singleton.Instance;

        private BuiltInFunctionLookup()
        {
        }

        private static class Singleton
        {
            public static BuiltInFunctionLookup Instance = new BuiltInFunctionLookup();
        }
    }
}
