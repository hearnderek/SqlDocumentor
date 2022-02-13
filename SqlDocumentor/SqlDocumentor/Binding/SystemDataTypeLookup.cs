using Microsoft.SqlServer.Management.SqlParser.Metadata;
using Microsoft.SqlServer.Management.SqlParser.MetadataProvider;

namespace SqlDocumentor.Binding
{
    /// <summary>
    /// This class only exists because I want to Bind my SqlDatabaseMetadataProvider, and I need to implement the whole interface.
    /// </summary>
    internal class SystemDataTypeLookup : SystemDataTypeLookupBase
    {
        private readonly IgnoreArgTypes m_ignoreArgs;

        /// <summary>
        /// Gets singleton instance of the <see cref="T:Microsoft.SqlServer.Management.SqlParser.MetadataProvider.Internals.SystemDataTypeLookup" /> class.
        /// </summary>
        public static SystemDataTypeLookup Instance => Singleton.Instance;

        private SystemDataTypeLookup() => m_ignoreArgs = new IgnoreArgTypes();

        public IgnoreArgTypes IgnoreArgs => m_ignoreArgs;

        private static class Singleton
        {
            public static SystemDataTypeLookup Instance = new SystemDataTypeLookup();
        }

        public class IgnoreArgTypes
        {
            private readonly ISystemDataType m_binary;
            private readonly ISystemDataType m_char;
            private readonly ISystemDataType m_dateTime2;
            private readonly ISystemDataType m_dateTimeOffset;
            private readonly ISystemDataType m_decimal;
            private readonly ISystemDataType m_nchar;
            private readonly ISystemDataType m_numeric;
            private readonly ISystemDataType m_nvarChar;
            private readonly ISystemDataType m_time;
            private readonly ISystemDataType m_varBinary;
            private readonly ISystemDataType m_varChar;

            public IgnoreArgTypes()
            {
                // Commented all of these out because they refer to internals

                //this.m_binary = (ISystemDataType)SystemDataType.SystemDataTypeFactory.Binary.GetDataType(true);
                //this.m_char = (ISystemDataType)SystemDataType.SystemDataTypeFactory.Char.GetDataType(true);
                //this.m_dateTime2 = (ISystemDataType)SystemDataType.SystemDataTypeFactory.DateTime2.GetDataType(true);
                //this.m_dateTimeOffset = (ISystemDataType)SystemDataType.SystemDataTypeFactory.DateTimeOffset.GetDataType(true);
                //this.m_decimal = (ISystemDataType)SystemDataType.SystemDataTypeFactory.Decimal.GetDataType(true);
                //this.m_nchar = (ISystemDataType)SystemDataType.SystemDataTypeFactory.NChar.GetDataType(true);
                //this.m_numeric = (ISystemDataType)SystemDataType.SystemDataTypeFactory.Numeric.GetDataType(true);
                //this.m_nvarChar = (ISystemDataType)SystemDataType.SystemDataTypeFactory.NVarChar.GetDataType(true);
                //this.m_time = (ISystemDataType)SystemDataType.SystemDataTypeFactory.Time.GetDataType(true);
                //this.m_varBinary = (ISystemDataType)SystemDataType.SystemDataTypeFactory.VarBinary.GetDataType(true);
                //this.m_varChar = (ISystemDataType)SystemDataType.SystemDataTypeFactory.VarChar.GetDataType(true);
            }

            public ISystemDataType Binary => m_binary;

            public ISystemDataType Char => m_char;

            public ISystemDataType DateTime2 => m_dateTime2;

            public ISystemDataType DateTimeOffset => m_dateTimeOffset;

            public ISystemDataType Decimal => m_decimal;

            public ISystemDataType NChar => m_nchar;

            public ISystemDataType Numeric => m_numeric;

            public ISystemDataType NVarChar => m_nvarChar;

            public ISystemDataType Time => m_time;

            public ISystemDataType VarBinary => m_varBinary;

            public ISystemDataType VarChar => m_varChar;
        }
    }
}
