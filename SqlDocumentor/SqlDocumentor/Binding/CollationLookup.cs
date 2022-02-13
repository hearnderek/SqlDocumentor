using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;

namespace SqlDocumentor.Binding
{
    /// <summary>
    /// I have no idea why they didn't just make this public...
    /// Ah it's because it clashes with some other class.
    /// This class only exists because I want to Bind my SqlDatabaseMetadataProvider, and I need to implement the whole interface.
    /// </summary>
    internal class CollationLookup : CollationLookupBase
    {
        /// <summary>
        /// Gets singleton instance of the <see cref="T:Microsoft.SqlServer.Management.SqlParser.MetadataProvider.Internals.CollationLookup" /> class.
        /// </summary>
        public static ICollationLookup Instance => Singleton.Instance;

        private CollationLookup()
        {
        }

        private static class Singleton
        {
            public static CollationLookup Instance = new CollationLookup();
        }
    }
}
